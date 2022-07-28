using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TutorialCanvas : MonoBehaviour
{ 
    public int combo;
    void Update()
    {
            if (combo >=1)
            {
                SceneManager.LoadScene("Tittle_Scene");
            }
     }
}
