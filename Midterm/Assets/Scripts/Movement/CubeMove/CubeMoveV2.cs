using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveV2 : MonoBehaviour
{
    public float VelocityOfCube = 1.25f;
    Vector3 Apoint;
    Vector3 Bpoint;

    // Start is called before the first frame update
    void Start()
    {
        Apoint = new Vector3(235, 24, -125);
        Bpoint = new Vector3(235, 3, -125);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * VelocityOfCube, 1);

        transform.position = Vector3.Lerp(Apoint, Bpoint, time);
    }
}//Mathf.PingPong(Time.time * 2, highMaxDist - lowMinDist)
