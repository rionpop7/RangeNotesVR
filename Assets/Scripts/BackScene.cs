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

    //�R���[�`���֐����`
    private IEnumerator Corou1() //�R���[�`���֐��̖��O
    {
        //�R���[�`���̓��e
        Debug.Log("�X�^�[�g");
        yield return new WaitForSeconds(25.0f);
        Debug.Log("�X�^�[�g����25�b��");
        SceneManager.LoadScene("Tittle_Scene");
    }

}
