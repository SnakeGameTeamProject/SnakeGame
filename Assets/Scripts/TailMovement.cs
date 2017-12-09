using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour {

    public float speed;
    public Vector3 tailPrevious;
    public GameObject tailPreviousSec;
    public SnakeMovement mainSnake;
    void Start () {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed=mainSnake.speed;
        tailPreviousSec = mainSnake.tailSections[mainSnake.tailSections.Count-2];
	}
	
	// Update is called once per frame
	void Update () {
        tailPrevious = tailPreviousSec.transform.position;
        transform.LookAt(tailPrevious);
        transform.position = Vector3.Lerp(transform.position, tailPrevious,Time.deltaTime*speed);
	}
}
