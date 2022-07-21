using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datascale : MonoBehaviour
{
    float scale = SphereScale.scale;
    void Start()
    {
     Debug.Log(scale + "ê¨å˜ÅIÅI");
     GameObject obj = GameObject.Find("Pivot");
     obj.transform.localScale = new Vector3(scale, scale, scale);
    }
}