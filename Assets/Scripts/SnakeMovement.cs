using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {


    public List<GameObject> tailSections = new List<GameObject>();

    public float speed;
    public float speedRotation;
    public float displacement = 0.5f;
    public GameObject TailObject;

    public Text Score;
    public int score = 0;
  
    // Use this for initialization
    void Start () {
        tailSections.Add(gameObject);	
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = score.ToString();

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

   public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailSections[tailSections.Count-1].transform.position;
        newTailPos.z -= displacement;
        tailSections.Add(GameObject.Instantiate(TailObject, newTailPos, Quaternion.identity) as GameObject);
    }
}
