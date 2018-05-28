using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Script : MonoBehaviour {
    public Rigidbody rb;
    public Transform Duck;
    public Transform Respawn;
	// Use this for initialization
	void Start () {
        rb.AddForce(-500, 0, 0 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
      
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
