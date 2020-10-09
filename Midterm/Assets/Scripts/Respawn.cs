using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private MasterG mg;
    void Start()
    {
        mg = GameObject.FindGameObjectWithTag("MG").GetComponent<MasterG>();
    }
    void OnTriggerEnter (Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            mg = GameObject.FindGameObjectWithTag("MG").GetComponent<MasterG>();
            mg.LRespawnPos = transform.position;
        }
    }
    // Start is called before the first frame update
   
}
