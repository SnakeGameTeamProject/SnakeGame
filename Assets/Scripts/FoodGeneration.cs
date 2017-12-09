using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

    public float X = 8.6f;
    public float Z = 8.6f;


    public GameObject foodObject;

    public GameObject foodAdd;

    public Vector3 position;


  
    void AddNewFood () {
        FoodPosition();
        foodAdd = GameObject.Instantiate(foodObject, position, Quaternion.identity) as GameObject;
    }
	void FoodPosition()
    {
       position = new Vector3(Random.Range(X * -1, X), 1f, Random.Range(Z * -1, Z));
    }
    
    void Update()
    {
        if(!foodAdd)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
   
}
