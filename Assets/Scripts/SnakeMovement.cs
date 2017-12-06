using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {


    public GameObject[] tailSections = new GameObject[0];

    public float speed;
    public float speedRotation;
    public float displacement = -0.5f;
  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * speedRotation * Time.deltaTime);
        }
    }
}
