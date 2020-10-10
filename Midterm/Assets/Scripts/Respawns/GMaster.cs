using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Respawn Manager
//Keeps last position of respawn point
//also makes sure object doesn't destroy itself in respawn
public class GMaster : MonoBehaviour
{
    public static GMaster instance;
    public Vector3 LRespawnPos;

    private void Awake()
    {
        if (instance == null)


        { instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
