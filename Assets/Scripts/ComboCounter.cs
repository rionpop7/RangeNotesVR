using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComboCounter : MonoBehaviour
{
    public static int combo = 0;
    public int _combo = 0;
    public Text comboDisplay;

    private void Update()
    {
        _combo = combo;
    }

    public void ComboScore(int point)
    {
        if (comboDisplay == null)
        {
            return;
        }


        if (point <= 0) //Combo Failed
        {
            comboDisplay.enabled = false;
            combo = 0;
            PlayerPrefs.SetInt("combo", 0);
            PlayerPrefs.Save();
            comboDisplay.text = "";
        }

        else if (point > 0) //Combo Success
        {
            comboDisplay.enabled = true;
            combo += point;
            comboDisplay.text = $"x {combo}";
        }
    }
}
