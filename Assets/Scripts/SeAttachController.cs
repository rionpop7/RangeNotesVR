using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeAttachController : MonoBehaviour
{
    public AudioSource audioSource;
    public ScoreCounter scoreCounter;
    public ComboCounter comboCounter;
    public AudioClip Faile;
    NotesItem notesItem;

    // Start is called before the first frame update
    void Start()
    {
        notesItem = this.gameObject.GetComponent<NotesItem>();
        audioSource = GameObject.Find("SE SYSTEM").GetComponent<AudioSource>();
        notesItem.SE = audioSource;

        

        notesItem = this.gameObject.GetComponent<NotesItem>();
        scoreCounter = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
        notesItem.scoreCounter = scoreCounter;

        notesItem = this.gameObject.GetComponent<NotesItem>();
        comboCounter = GameObject.Find("ComboCounter").GetComponent<ComboCounter>();
        notesItem.comboCounter = comboCounter;

    }

}
