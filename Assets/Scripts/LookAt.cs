using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject player;
    private GameObject sphere;

    void Start()
    {
        //�v���C���[
        player = GameObject.Find("Main Camera");
    }

    void Update()
    {
        //look at player object which is camera
        transform.LookAt(player.transform);

    }
}