using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Corou1");
    }

    //コルーチン関数を定義
    private IEnumerator Corou1() //コルーチン関数の名前
    {
        //コルーチンの内容
        Debug.Log("スタート");
        yield return new WaitForSeconds(25.0f);
        Debug.Log("スタートから25秒後");
        SceneManager.LoadScene("Tittle_Scene");
    }

}
