using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int random;


    float invokeRate = 1f;

    public GameObject[] targets;

    
    void Start()
    {

        InvokeRepeating("spawn",1,invokeRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void spawn()
    {
        random = Random.Range(0, 4);

        Instantiate(targets[random], targets[random].transform.position, targets[random].transform.rotation);
    }
}
