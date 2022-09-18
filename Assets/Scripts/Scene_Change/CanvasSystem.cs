using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasSystem : MonoBehaviour
{
    public GameObject CanvasA;
    public GameObject CanvasB;
    public GameObject Dorm;
    public GameObject ScaleSetting;
    public GameObject Option;
    public GameObject Volume;
    public GameObject LoadPlay1;
    public GameObject LoadPlay2;
    public GameObject WhiteCanvas;
    public AudioSource SE;
    public AudioClip Voice01;
    public AudioClip Voice02;
    public AudioClip Voice15;
    public AudioClip Back;
    public AudioClip SoundLogo;
    public AudioClip MainThemeLoop;

    void Start()
    {

        CanvasB.SetActive(false);
        Option.SetActive(false);
        Dorm.SetActive(false);
        ScaleSetting.SetActive(false);
        Volume.SetActive(false);
        WhiteCanvas.SetActive(true);
        StartCoroutine(DelayCoroutine());
        StartCoroutine(DelayCoroutine1());

    }

    private IEnumerator DelayCoroutine()
    {
        // 3•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(1.5f);
        SE.PlayOneShot(SoundLogo);
        SE.PlayOneShot(Voice15);
        CanvasA.SetActive(true);
        WhiteCanvas.SetActive(false);

    }

    private IEnumerator DelayCoroutine1()
    {
    yield return new WaitForSeconds(5f);
    SE.PlayOneShot(MainThemeLoop);
    }

    public GameObject Onclick;

    public void MovetoSelect()
    {
        CanvasA.SetActive(false);
        CanvasB.SetActive(true);
        SE.PlayOneShot(Voice01);
    }

    public void ToMain()
    {
        CanvasA.SetActive(true);
        CanvasB.SetActive(false);
        Option.SetActive(false);
        SE.PlayOneShot(Back);
    }

    public void ToOption()
    {
        Option.SetActive(true);
        CanvasB.SetActive(false);
        CanvasA.SetActive(false);
    }
    public void SphereScale()
    {
        ScaleSetting.SetActive(true);
        Dorm.SetActive(true);
        Option.SetActive(false);
    }

    public void BackToOption()
        {
        ScaleSetting.SetActive(false);
        Option.SetActive(true);
        Dorm.SetActive(false);
        Volume.SetActive(false);
        SE.PlayOneShot(Back);
    }

    public void VolumeSetting()
    {
        
        ScaleSetting.SetActive(false);
        Option.SetActive(false);
        Volume.SetActive(true);

    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial_Scene");
    }

  

}