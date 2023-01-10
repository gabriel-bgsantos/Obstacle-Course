using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float yAngle = 10f; //find a way to accelerate this shit

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, yAngle, 0);
    }
}
