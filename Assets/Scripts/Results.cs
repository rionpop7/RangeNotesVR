using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{

    public static int results;
    public int combo = 0;
    public int maxcombo;
    public Text scoreDisplay;
    public Text notesResults;
    public Text maxCombo;
    public static int maxsensei = 0;
    int scorenumber;

    private void Start() //�R�[���`���Ŋm�F�\��B
    {
        if (ScoreCounter.score >= 0f && ScoreCounter.score <= scorenumber * 0.5f)
        {
            gameObject.SetActive(true);
        }
        else if (ScoreCounter.score > scorenumber * 0.5f && ScoreCounter.score <= scorenumber *0.7f) //B�]��
        {
           
        }
        else if (ScoreCounter.score > scorenumber * 0.8f && ScoreCounter.score <= scorenumber *0.9f)�@//A�]��
        {
           
        }
        else if (ScoreCounter.score > scorenumber * 0.9f && ScoreCounter.score <= scorenumber)�@//S�]��
        {

        }
    }

    public void NotesResults()
    {
        
        if (ComboCounter.combo >= maxsensei)
        {
            ++ maxsensei;

            Debug.Log("{�ӂ��Ă�}");
        }
    }

    //public void ComboResults(int point)
    //{


    //    if(point > 0) //Combo Success
    //    {
    //        combo += point;
    //        maxCombo.text = $"Combo {combo}";
    //    }
    //}

    public void Update() 
    {
        scoreDisplay.text = $"Score {ScoreCounter.score}"; //
        scorenumber = NotesItem.notesnumber * 100; //�ő�X�R�A
        notesResults.text = $"{NotesItem.notesHitamount} /{NotesItem.notesnumber}";  //notes  0/0
        maxCombo.text = $"{maxsensei}/{NotesItem.notesnumber}";

        if (ComboCounter.combo > maxsensei)
        {
            ++maxsensei;

            Debug.Log("{�ӂ��Ă�}");
        }



    }
}