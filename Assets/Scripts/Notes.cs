using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using System.Linq;
using UnityEngine.Timeline;
using UnityEngine.Assertions;

public class Notes : MonoBehaviour
{
    public GameObject Player;
    public GameObject Notesobject;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�Ԃ����Ă��邩");

  
            Notesobject.gameObject.SetActive(false);

        
    }
}