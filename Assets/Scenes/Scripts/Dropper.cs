using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dropper : MonoBehaviour
{
    private Rigidbody rb;
    private new MeshRenderer renderer;
    public float range; //declare here

    // Start is called before the first frame update
    void Start()
    {  
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        range = (int)Random.Range(0f, 5f); //assign it here
        Debug.Log(range);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(renderer.material.color);
        Debug.Log(Time.time);
        if(range == (int)Time.time){ //it is int because it needs to be exactly equal
            renderer.enabled = true;
            rb.useGravity = true;
            Debug.Log("Dropped");   
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        gameObject.tag = "Hit";
        
        if(other.gameObject.tag == "Player"){ //create smt that it doesnt change the color again after first hit
            renderer.material.color = Color.cyan;  
        }
        else{
            renderer.material.color = Color.red;
            //gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
