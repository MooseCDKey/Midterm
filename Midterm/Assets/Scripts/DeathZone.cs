using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//if player dies, level will reload
public class DeathZone : MonoBehaviour
{
    public GMaster GM;

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //GM.LRespawnPos = transform.position;

        }
    }
}
