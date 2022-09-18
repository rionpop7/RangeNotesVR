using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    int selectCharaNumber;
    private GameObject gameStartButton;

     private void Start()
    {
        selectCharaNumber = 0;
        gameStartButton = GameObject.Find("StartButton");
        gameStartButton.SetActive(false);
    }

    public void OnClickA()
    {
        selectCharaNumber = 0;
        gameStartButton.SetActive(true);
    }
    public void BurningHeart()
    {
        selectCharaNumber = 1;
        gameStartButton.SetActive(true);
    }

    public void ShiningStar()
    {
        selectCharaNumber = 2;
        gameStartButton.SetActive(true);
    }

    public void Alpus10000jyaku()
    {
        selectCharaNumber = 3;
        gameStartButton.SetActive(true);
    }
    public void PartyMaker()
    {
        selectCharaNumber = 4;
        gameStartButton.SetActive(true);
    }


        public void onClickStart()
    {
        PlayerPrefs.SetInt("Chara_number", selectCharaNumber);

        if (selectCharaNumber == 0)//01
        {
            SceneManager.LoadScene("MainTheme");
        }
        if(selectCharaNumber == 1) //BurningFire
        {
            SceneManager.LoadScene("BurningHeart");
        }

        if (selectCharaNumber == 2) //ShiningStar
        {
            SceneManager.LoadScene("ShiningStar");
        }

        if (selectCharaNumber == 3) //Alpus10000jyaku
        {
            SceneManager.LoadScene("Alpus10000jyaku");
        }
        if (selectCharaNumber == 4) //PartyMaker
        {
            SceneManager.LoadScene("PartyMaker");
        }

    }
}
