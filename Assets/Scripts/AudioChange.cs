using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioChange : MonoBehaviour
{
    //AudoClipの配列、clipsを宣言します。
    public AudioClip[] clips;
    //AudioSource型の変数audiosを宣言します。
    AudioSource audios;

    void Start()
    {
        //GetComponenntoでAudioSourceコンポーネントにアクセスして
        //変数audiosで参照します。
        audios = GetComponent<AudioSource>();

    }

    //Button1がクリックされた時の処理
    public void Button1Click()
    {
        //配列変数clipのインデックスが０のAudioのファイルを再生します。
        audios.clip = clips[0];
        audios.Play();
        //選択からの再生
    }

    //Button2がクリックされた時の処理
    public void Button2Click()
    {
        //配列変数clipのインデックスが１のAudioのファイルを再生します。
        audios.clip = clips[1];
        audios.Play();
    }

    //Button3がクリックされた時の処理
    public void Button3Click()
    {
        //配列変数clipのインデックスが２のAudioのファイルを再生します。
        audios.clip = clips[2];
        audios.Play();
    }

    //Button4がクリックされた時の処理
    public void Button4Click()
    {
        //配列変数clipのインデックスが3のAudioのファイルを再生します。
        audios.clip = clips[3];
        audios.Play();
    }

    //Button5がクリックされた時の処理
    public void Button5Click()
    {
        //配列変数clipのインデックスが２のAudioのファイルを再生します。
        audios.clip = clips[4];
        audios.Play();
    }

}