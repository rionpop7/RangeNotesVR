using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSample : MonoBehaviour
{
    public GameObject TittleMenu;
    public GameObject SelectMenu;

    private void MoveToSelect()
    {
       SelectMenu.gameObject.SetActive(true);
       TittleMenu.gameObject.SetActive(false);
    }

    private void BackToMain()
    {
        TittleMenu.gameObject.SetActive(true);
        SelectMenu.gameObject.SetActive(false);
    }
}
