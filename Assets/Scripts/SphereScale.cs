using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereScale : MonoBehaviour
{
    public static float scale = 2;  //scale
    public Slider slider;
    void Start()
    {
        slider = GameObject.Find("Slider(SphereScale)").GetComponent<Slider>();
    }
    public void ScaleAdjust()
    {
    GameObject obj = GameObject.Find("Pivot");
    scale = slider.value;
    obj.transform.localScale = new Vector3(scale, scale, scale);
    }

}
