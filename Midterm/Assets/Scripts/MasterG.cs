using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterG : MonoBehaviour
{
    private static MasterG instance;
    public Vector3 LRespawnPos;

    private void Awake()
    {
        if(instance == null)
        { instance = this;
            DontDestroyOnLoad(instance);
        }
        else 
        { Destroy(gameObject); }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
