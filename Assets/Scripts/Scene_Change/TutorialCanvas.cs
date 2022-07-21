using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialCanvas : MonoBehaviour
{
    public int combo;
    private void Update()
    {
        if (combo >= 4)
        {
            SceneManager.LoadScene("Tittle_Scene");
        }
    }


    public void Back()
    {
        SceneManager.LoadScene("Tittle_Scene");
    }
}
