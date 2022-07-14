using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;


public class ScrollButtonController : MonoBehaviour
{
    public RectTransform scrollPos;
    public float offsetVal = 47f;
   // public ScrollRect scrollRect;

    // Start is called before the first frame update
    void Start()
    {
       // scrollRect.verticalNormalizedPosition = 1.0f;
        scrollPos.localPosition = new Vector3(0f,0f,0f);
    }

    public void OnTapUp()
    {
        Debug.Log("up");
        scrollPos.localPosition = new Vector3(0f, scrollPos.localPosition.y + offsetVal, 0f);
    }

    public void OnTapDown()
    {
        Debug.Log("down");
        scrollPos.localPosition = new Vector3(0f, scrollPos.localPosition.y - offsetVal, 0f);
    }
}
