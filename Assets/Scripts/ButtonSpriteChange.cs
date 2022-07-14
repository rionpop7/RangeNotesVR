using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodBom : MonoBehaviour
{
    Image buttonImage_;

    void Start()
    {
        // コンポーネントからImageを取得
        buttonImage_ = GetComponent<Image>();
    }

    void Update()
    {
        //buttonImage_.sprite = "適用したいSprite";

    }
}