using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour {

 	void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovement>().AddTail();
            Destroy(gameObject);
        }
    }
}
