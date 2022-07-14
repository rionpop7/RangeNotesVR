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

    void Start()
    {
        CanvasA.SetActive(true);
        CanvasB.SetActive(false);
        Option.SetActive(false);
        Dorm.SetActive(false);
        ScaleSetting.SetActive(false);
        Volume.SetActive(false);

    }

    public GameObject Onclick;

    public void MovetoSelect()
    {
        CanvasA.SetActive(false);
        CanvasB.SetActive(true);
    }

    public void ToMain()
    {
        CanvasA.SetActive(true);
        CanvasB.SetActive(false);
        Option.SetActive(false);
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
    }

    public void VolumeSetting()
    {
        
        ScaleSetting.SetActive(false);
        Option.SetActive(false);
        Volume.SetActive(true);

    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Test");
    }

    public void Load_BurningHeart()
    {
        SceneManager.LoadScene("Scene_BuringHeart");
    }

}