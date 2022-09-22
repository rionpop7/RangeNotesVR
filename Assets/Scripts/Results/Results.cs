using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{

    public static int results;
    public static int combo = 0;
    public static int maxcombo;
    public Text scoreDisplay;
    public Text notesResults;
    public Text maxCombo;
    public static int maxsensei = 0; //マックスコンボ
    int scorenumber;
    static int notesTotal;



    public void NotesResults()
    {
        
        if (ComboCounter.combo >= maxsensei)
        {
            ++ maxsensei;

            Debug.Log("{ふえてく}");
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
        //scorenumber = NotesItem.notesnumber * 100; //最大スコア
        notesResults.text = $"{NotesItem.notesHitamount} /{NotesItem.notesnumber}";  //notes  0/0
        maxCombo.text = $"{maxsensei}/{NotesItem.notesnumber}";

        if (ComboCounter.combo > maxsensei)
        {
            ++maxsensei;

            Debug.Log("{ふえてく}");
        }



    }
}