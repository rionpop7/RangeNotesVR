using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboCounter : MonoBehaviour
{
    public int combo;
    public Text comboDisplay;



    public void ComboScore(int point)
    {
        if (point <= 0)
        {
            comboDisplay.enabled = false;
            combo = 0;
            PlayerPrefs.SetInt("combo", 0);
            PlayerPrefs.Save();
            comboDisplay.text = "Combo 0";
        }

        else if (point > 0)
        {
            comboDisplay.enabled = true;
            combo += point;
            comboDisplay.text = $"Combo {combo}";
        }
    }
}
