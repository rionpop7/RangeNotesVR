using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultsCanvas : MonoBehaviour
{
    public TextMeshProUGUI notesResults;
    public TextMeshProUGUI comboNumber;
    public TextMeshProUGUI Score;
    public GameObject Fullcombo;
    int notesTotal = NotesItem.notesnumber;//Å‘åƒm[ƒc
    int amount = NotesItem.notesHitamount; //ƒqƒbƒg”
    int score = ScoreCounter.score;//ƒXƒRƒA
    int maxcombo = Results.maxsensei;@//Å‘åƒRƒ“ƒ{
    int scoreTotal = NotesItem.notesnumber * 100; //Å‘åƒXƒRƒA
    public GameObject Backtomain;
    public AudioSource SE;
    public AudioClip resultmusic;
    public GameObject C;
    public GameObject B;
    public GameObject A;
    public GameObject S;
    public GameObject SS;
    public AudioClip voice_06; //SS
    public AudioClip voice_07; //S
    public AudioClip voice_08; //A
    public AudioClip voice_09; //B
    public AudioClip voice_10; //C
    //public TextMeshProUGUI rankresults;


    void Start()
    {
        Fullcombo.SetActive(false);
        notesResults.text = $"{amount}/{notesTotal}";
        comboNumber.text = $"{maxcombo}";
        Score.text = $"{score}";
        SE.PlayOneShot(resultmusic); //ƒŠƒUƒ‹ƒg‰¹Šy
        StartCoroutine(resultcourtine());//ƒR[ƒ‹ƒ`ƒ“ƒXƒ^[ƒg
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        S.SetActive(false);
        SS.SetActive(false);


        if (score >= 0f && score <= scoreTotal * 0.5f) //C•]‰¿
        {
            //gameObject.SetActive(true);
            //SE.PlayOneShot(voice_10);
            //rankresults.text= "C";
            C.SetActive(true);
        }
        else if (score > scoreTotal * 0.5f && score <= scoreTotal * 0.8f) //B•]‰¿
        {
            // SE.PlayOneShot(voice_09);
            //rankresults.text = "B";
            B.SetActive(true);
        }
        else if (score > scoreTotal * 0.8f && score <= scoreTotal * 0.9f) //A•]‰¿
        {
            //SE.PlayOneShot(voice_08);
            //rankresults.text = "A";
            A.SetActive(true);

        }
        else if (score > scoreTotal * 0.9f && score <= scoreTotal * 0.95f) //S•]‰¿
        {
            // SE.PlayOneShot(voice_07);
            //rankresults.text = "S";
            S.SetActive(true);
        }
        else if (score > scoreTotal * 0.95f && score < scoreTotal * 1f) //SS•]‰¿
        {
            // SE.PlayOneShot(voice_06);
            //rankresults.text = "SS";
            SS.SetActive(true);
        }

        else if (amount == notesTotal) //Fullcombo
        {
            Fullcombo.SetActive(true);
        
        }
    }

    private IEnumerator resultcourtine()
    {
        yield return new WaitForSeconds(6f);

        if (score >= 0f && score <= scoreTotal * 0.5f) //C•]‰¿
        {
            //gameObject.SetActive(true);
            SE.PlayOneShot(voice_10);
        }
        else if (score > scoreTotal * 0.5f && score <= scoreTotal * 0.8f) //B•]‰¿
        {
            SE.PlayOneShot(voice_09);
        }
        else if (score > scoreTotal * 0.8f && score <= scoreTotal * 0.9f) //A•]‰¿
        {
            SE.PlayOneShot(voice_08);
        }
        else if (score > scoreTotal * 0.9f && score <= scoreTotal * 0.95f) //S•]‰¿
        {
            SE.PlayOneShot(voice_07);
        }
        else if (score > scoreTotal * 0.95f && score <= scoreTotal * 1f) //SS•]‰¿
        {
            SE.PlayOneShot(voice_06);
        }
    }

    public void BacktoTittle()//ƒ^ƒCƒgƒ‹‚É–ß‚é 
    {
        notesTotal = 0;
        score = 0;
        scoreTotal = 0;
        SceneManager.LoadScene("Tittle_Scene");
    }
}