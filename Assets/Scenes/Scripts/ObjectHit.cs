using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("IT'S WORKING BIATCH");
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
