using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public GameObject CanvasA;
    public GameObject CanvasB;
    public GameObject CanvasC;
    public GameObject Option;
    public GameObject LoadPlay1;
    public GameObject LoadPlay2;
    public GameObject LoadPlay3;

    public void StartGame()
    {
        CanvasA.SetActive(false);
    }
}
