using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRig : MonoBehaviour
{
    public Transform TargetNotes;
    public GameObject DeleteEffect;

 
    void Update()
    {
        transform.LookAt(TargetNotes);
    }

   
}

