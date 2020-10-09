using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove2 : MonoBehaviour
{
    public float VelocityOfCube = 1.25f;
    Vector3 Apoint;
    Vector3 Bpoint;
    // Use this for initialization
    void Start()
    {

        Apoint = new Vector3(153, 17, 94);
        Bpoint = new Vector3(153, 17, 208);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * VelocityOfCube, 1);

        transform.position = Vector3.Lerp(Apoint, Bpoint, time);
    }
}