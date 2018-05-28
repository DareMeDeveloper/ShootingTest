using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Script : MonoBehaviour {
    public Rigidbody rb;
    public Transform Duck;
    public Transform Respawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(-10, 0, 0 * Time.deltaTime);
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DuckWall")
        {
            Duck.transform.position = Respawn.transform.position;
        }
        if (other.tag == "Bullit")
        {
            Destroy(gameObject);
        }
    }
}
