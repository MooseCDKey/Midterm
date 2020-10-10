using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Finds the Spawn Manager tag in scene
//if player collides with space, change last respawn position to current position
public class RespawnPoints : MonoBehaviour
{
    private GMaster GM;
    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GMaster>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //transform.position = GM.LRespawnPos;
            Debug.Log("PlayerCollided");
            
        }
    }
}
