using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// "AudioSource"コンポーネントがアタッチされていない場合アタッチ
[RequireComponent(typeof(AudioSource))]
public class ChangeSoundVolume : MonoBehaviour
{

	public AudioMixer mixer;
	public string target = "BGM";

	private void Start()
	{
	}

	/// <summary>
	/// スライドバー値の変更イベント
	/// </summary>
	/// <param name="newSliderValue">スライドバーの値(自動的に引数に値が入る)</param>
	public void SoundSliderOnValueChange(float newSliderValue)
	{
		mixer.SetFloat(target, newSliderValue);
	}
}