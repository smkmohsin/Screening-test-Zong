using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerManager.lastCheckPoint = transform.position;
        }
    }
}
