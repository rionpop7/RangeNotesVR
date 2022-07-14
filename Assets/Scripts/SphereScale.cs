using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereScale : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider = GameObject.Find("Slider(SphereScale)").GetComponent<Slider>();
    }

    public void ScaleAdjust()
    {
        GameObject obj = GameObject.Find("Pivot");
        float scale = slider.value;
        obj.transform.localScale = new Vector3(scale, scale, scale);
    }
}