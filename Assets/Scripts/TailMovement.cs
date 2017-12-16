using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{

    public float speed;
    public Vector3 tailPrevious;
    public GameObject tailPreviousSec;
    public SnakeMovement mainSnake;

    public int id;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed = mainSnake.speed + 2.5f;
        tailPreviousSec = mainSnake.tailSections[mainSnake.tailSections.Count - 2];
        id = mainSnake.tailSections.IndexOf(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        tailPrevious = tailPreviousSec.transform.position;
        transform.LookAt(tailPrevious);
        transform.position = Vector3.Lerp(transform.position, tailPrevious, Time.deltaTime * speed);
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("SnakeMain"))
        {
            if(id>3)
            {
                Application.LoadLevel(0);
            }
        }
    }

}
