using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public GameObject gameObject;
    float nextSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (nextSpawn < 0)
        {
            Vector2 PositionOnCircle = Random.insideUnitCircle.normalized * 8f;
        }
       
    }
}
