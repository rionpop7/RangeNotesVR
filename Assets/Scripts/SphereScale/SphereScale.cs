using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereScale : MonoBehaviour
{
    public static float scale = 1.8f;  //scale
    public Slider slider;
    public GameObject pivot;

    void Start()
    {
        //slider = GameObject.Find("Slider(SphereScale)").GetComponent<Slider>();
    }

    public void ScaleAdjust()
    {
        scale = slider.value;
        pivot.transform.localScale = new Vector3(scale,scale,scale);
        //Debug.Log(scale);
    }

}
