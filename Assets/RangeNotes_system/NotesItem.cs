using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;
using System.Collections;
using System;

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
    public AudioClip Faile;
    //public ParticleSystem Arrow;
    public SphereCollider Collider;
    public bool HitChecker = false; //�R���{�Ɋւ���u�[��]
    public static int notesnumber = 0;
    public static int notesHitamount; // ���������m�[�c�̐��B
    
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
                ++notesHitamount; //���������m�[�c�̐����J�E���g
                hitEffect.Play(true);
                HitChecker = true;
                Collider.enabled = false;
                Invoke(nameof(DelayMethod), 2f); //�R���C�_�[�������i���i�q�b�g��h���j

                if (bothTag)
                {
                    StartCoroutine(Vibrate(duration: 0.5f, controller: OVRInput.Controller.Touch));
                    Debug.Log($"Both are vibrationg");
                }
            }

            //if (hitEffect != null)
            {
                hitEffect.Play(true);
            }


            if (normalizedTime >= 0f && normalizedTime <= 0.42f)
            {
                Debug.Log($"Too Fast");
                scoreCounter.AddScore(50);
                comboCounter.ComboScore(0);

                SE.PlayOneShot(Faile);
            }
            else if (normalizedTime > 0.42f && normalizedTime <= 0.6f)
            {
                Debug.Log($"Just");
                scoreCounter.AddScore(100);
                comboCounter.ComboScore(1);
                SE.PlayOneShot(CLIP);
            }
            else if (normalizedTime > 0.6f)
            {
                Debug.Log($"Too Slow");
                scoreCounter.AddScore(50);
                comboCounter.ComboScore(0);
                SE.PlayOneShot(Faile);
            }

        }
    }

    private bool _tagCheck(string targetTagName1)
    {
        throw new NotImplementedException();
    }


    void DelayMethod()�@//�R���C�_�[�������i���i�q�b�g��h���j
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
            //StartCoroutine(DelayCoroutine_2());
        }

        if (activationEffect != null)
        {
            activationEffect.Play(true);
            //Arrow.gameObject.SetActive(true);
        }

        //�q�b�g�̃u�[���������l�ɖ߂�
        //if (HitChecker == true)
        //{
            HitChecker = false;
        //}
        ++notesnumber;
    }

    public override void OnStop()
    {

        //�q�b�g�Ȃ��ŃR���{���r�؂��
        if (HitChecker == false)
        {
            comboCounter.ComboScore(0);
            //ComboCounter.combo = 0;
            Debug.Log("�q�b�g�Ȃ�");
        }

        if (displayObject != null)
        {
            displayObject.SetActive(false);
        }
       

        if (activationEffect != null)
        {
            activationEffect.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            //Arrow.gameObject.SetActive(false);
        }

    }
    #endregion

    #region PRIVATE_METHODS
    bool _tagCheck(Collider other)
    {
        if (bothTag) //both hand activate
        {
            Debug.Log("both tag on");
            return (other.CompareTag(_targetTagName1)) || other.CompareTag(_targetTagName2);
        }
        else if (other.CompareTag(_targetTagName1))
        {
            Debug.Log("�݂��Ă���");
            StartCoroutine(Vibrate(duration: 0.5f, controller: OVRInput.Controller.RTouch));
            return (other.CompareTag(_targetTagName1));

        }
        else if (other.CompareTag(_targetTagName2))
        {
            StartCoroutine(Vibrate(duration: 0.5f, controller: OVRInput.Controller.LTouch));
            Debug.Log("�Ђ���Ă���");
            return (other.CompareTag(_targetTagName1));
        }
        else
        {
            Debug.Log("���̂�");
            return (other.CompareTag(_targetTagName1));
        }
 
    }

    public Vector3 defaultScale = Vector3.zero;

    void Start()
    {
        Debug.Log("������˂����[��");
        defaultScale = transform.lossyScale;
        //Collider.enabled = false;
    
    }
    //
    //private IEnumerator DelayCoroutine_2()
    //{
        // 0.3�b�ԑ҂��Ă���m�[�c���o��������
       // yield return new WaitForSeconds(0.3f);
       // Collider.enabled = true;
       // Debug.Log("�m�[�c�o��");
   // }
 
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