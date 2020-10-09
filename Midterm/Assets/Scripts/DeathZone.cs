using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private MasterG mg;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            mg = GameObject.FindGameObjectWithTag("MG").GetComponent<MasterG>();
            transform.position = mg.LRespawnPos;
        }
    }
}
