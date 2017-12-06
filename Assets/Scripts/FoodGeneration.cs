using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

    public float X = 8.6f;
    public float Z = 8.6f;


    public GameObject foodObject;

    public GameObject foodAdd;

    public Vector3 position;
    void FoodPosition()
    {
        position = new Vector3(Random.Range(X * -1, X), 1, Random.Range(Z * -1, Z));
    }
    // Use this for initialization
    void Start () {
        FoodPosition();
        foodAdd = Instantiate(foodObject, position, Quaternion.identity) as GameObject;
    }
	
}
