using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make player position the last spawn position transition
public class PPos : MonoBehaviour
{
    private GMaster GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GMaster>();

        transform.position = GM.LRespawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
