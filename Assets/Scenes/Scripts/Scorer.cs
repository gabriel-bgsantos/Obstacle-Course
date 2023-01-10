using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    private void OnCollisionEnter(Collision other) {
        counter++;
        Debug.Log("You've bumped into a thing " + counter + " times.");
    }
}
