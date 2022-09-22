using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    private GameObject Results;

    public void MovetoResults()
    {
        SceneManager.LoadScene("Results");
    }
}
