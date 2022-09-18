using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;



public class TutorialCanvas : MonoBehaviour
{ 
    public int Combo = ComboCounter.combo;
    public AudioSource SE;
    public AudioClip Voice_11;
    public AudioClip Voice_12;
    public AudioClip Voice_13;
    public AudioClip Voice_14;
    public AudioClip Voice_15;
    public GameObject RangeNotesKun_01;
    public GameObject RangeNotesKun_02;
    public GameObject RangeNotesKun_03;
    public GameObject RangeNotesKun_04;
    public GameObject Timeline_2;

    private bool Once = true;

    [SerializeField]
    public PlayableDirector Tutorial_02;
    private void Start()
    {
        RangeNotesKun_01.SetActive(true);
        SE.PlayOneShot(Voice_11);
        Timeline_2.SetActive(false);
        Tutorial_02.Stop();
    }


    public void Update()
    {
           if (ComboCounter.combo >= 4 && Once == true)
            {
            Destroy(GameObject.Find("Tutorial_01"));
            Debug.Log($"Setactive it working");
            Once = false;
            ComboCounter.combo = 0;
            StartCoroutine(DelayCoroutine_1());
            StartCoroutine(DelayCoroutine_2());
            Tutorial_02.Play();
        }

           if (ComboCounter.combo >= 8)
            {
            Timeline_2.SetActive(false);
            Tutorial_02.Stop();
            ComboCounter.combo = 0;
            StartCoroutine(DelayCoroutine_3());
        }
     }

    private IEnumerator DelayCoroutine_1()
    {
        // 2•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(2f);
        SE.PlayOneShot(Voice_12);
        RangeNotesKun_01.SetActive(false);
        RangeNotesKun_03.SetActive(true);
    }
    private IEnumerator DelayCoroutine_2()
    {
        // 5•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(5f);
        
        //Tutorial_02.Play();
        Timeline_2.SetActive(true);
        Debug.Log("colutine is working");     
    }

    private IEnumerator DelayCoroutine_3()
    {
        // 2•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(2f);
        RangeNotesKun_03.SetActive(false);
        RangeNotesKun_04.SetActive(true);
        SE.PlayOneShot(Voice_14);
        StartCoroutine(DelayCoroutine_4());
    }

    private IEnumerator DelayCoroutine_4()
    {
        // 5•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Tittle_Scene");
    }
}
