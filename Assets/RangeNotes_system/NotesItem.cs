using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;
using System.Collections;

public class NotesItem : PlayingEventItem
{
    #region DEFINITION
    #endregion

    #region VARIABLE
    public string _targetTagName1 = "Player";
    public string _targetTagName2 = "Player2";
    public bool bothTag = false;
    public GameObject displayObject;
    public ParticleSystem activationEffect;
    public ParticleSystem hitEffect;
    public ScoreCounter scoreCounter;
    public ComboCounter comboCounter;
    public int ComboScore;
    public AudioSource SE;
    public AudioClip CLIP;
    public ParticleSystem Arrow;
    public SphereCollider Collider;

    //�R���{�Ɋւ���u�[��
    bool HitChecker = false;
    public static IEnumerator Vibrate(float duration = 0.1f, float frequency = 0.1f, float amplitude = 0.5f, OVRInput.Controller controller = OVRInput.Controller.Active)
    {
        //�R���g���[���[��U��������
        OVRInput.SetControllerVibration(frequency, amplitude, controller);

        //�w�肳�ꂽ���ԑ҂�
        yield return new WaitForSeconds(duration);

        //�R���g���[���[�̐U�����~�߂�
        OVRInput.SetControllerVibration(0, 0, controller);
    }

    [Space]
    public UnityEvent<int> hitCallback;
    #endregion

    #region UNITY_EVENT
    void OnTriggerEnter(Collider other)
    {
        
        if (isPlaying && _tagCheck(other))
        {
            displayObject.SetActive(false);
        //    hitCallback?.Invoke(0);

            if (hitEffect != null)
            {
                hitEffect.Play(true);
                HitChecker = true;
                SE.PlayOneShot(CLIP);
                Collider.enabled = false;
                Invoke(nameof(DelayMethod), 2f);
                StartCoroutine(Vibrate(duration: 0.5f, controller: OVRInput.Controller.Active));
            }


            //if (hitEffect != null)
            {
                hitEffect.Play(true);
                SE.PlayOneShot(CLIP);
            }


            if (normalizedTime >= 0f && normalizedTime <= 0.4f)
            {
                Debug.Log($"Fast");
                scoreCounter.AddScore(50);
                comboCounter.ComboScore(0);
            }
            else if (normalizedTime > 0.4f && normalizedTime <= 0.6f)
            {
                Debug.Log($"Just");
                scoreCounter.AddScore(100);
                comboCounter.ComboScore(1);
            }
            else if (normalizedTime > 0.6f)
            {
                Debug.Log($"Slow");
                scoreCounter.AddScore(25);
                comboCounter.ComboScore(0);
            }


        }


    }


    //�R���C�_�[����
    void DelayMethod()
    {
        Debug.Log("Invoke Working");
        Collider.enabled = true;
    }

    #endregion

    #region PUBLIC_METHODS
    public override void OnPlay()
    {
        if (displayObject != null)
        {
            displayObject.SetActive(true);
    
        }

        if (activationEffect != null)
        {
            activationEffect.Play(true);
            Arrow.gameObject.SetActive(true);
        }

        //�q�b�g�̃u�[���������l�ɖ߂�
        if (HitChecker == true)
        {
            HitChecker = false;
        }
    }

    public override void OnStop()
    {
        if (displayObject != null)
        {
            displayObject.SetActive(false);
        }
       

        if (activationEffect != null)
        {
            activationEffect.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            Arrow.gameObject.SetActive(false);
        }

        //�q�b�g�Ȃ��ŃR���{���r�؂��
        if (HitChecker == false)
        {
            comboCounter.ComboScore(0);
        }
    }
    #endregion

    #region PRIVATE_METHODS
    bool _tagCheck(Collider other)
    {
        if (bothTag)
        {
            return (other.CompareTag(_targetTagName1) || other.CompareTag(_targetTagName2));
        }
        else
        {
            return (other.CompareTag(_targetTagName1));
        }
        
    }

    public Vector3 defaultScale = Vector3.zero;

    void Start()
    {
        defaultScale = transform.lossyScale;
    }

    void Update()
    {
        Vector3 lossScale = transform.lossyScale;
        Vector3 localScale = transform.localScale;

        transform.localScale = new Vector3(
                localScale.x / lossScale.x * defaultScale.x,
                localScale.y / lossScale.y * defaultScale.y,
                localScale.z / lossScale.z * defaultScale.z
        );
    }

    #endregion
}