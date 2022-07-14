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
        Debug.Log("‚Ô‚Â‚©‚Á‚Ä‚¢‚é‚©");

  
            Notesobject.gameObject.SetActive(false);

        
    }
}