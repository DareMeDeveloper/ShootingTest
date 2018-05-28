using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {
    public Transform Player;
    public Transform tran;
    public Rigidbody rb;
    public float Force;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider other)
    {
        Player.position = tran.position;

        if(other.tag == "Duck")
        {
            Debug.Log("I KILLED A DUCK");
        }
    }
    void OnMouseDown()
    {
        rb.AddForce(0, 0, Force * 10 * Time.deltaTime);
    }
}
