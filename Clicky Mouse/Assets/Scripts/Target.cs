using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour
{

    public GameObject explode;


    Sensor score;

    
    
    private Rigidbody targetRb;


    private void Start()
    {

        // handls the upward vilocity for the objects
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(Vector3.up * Random.Range(16, 20), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10,10) ,Random.Range(-10, 10), Random.Range(-10,10) ,ForceMode.Impulse);



        transform.position = new Vector3(Random.Range(-4, 4), -6);

        score = FindObjectOfType<Sensor>();

    }

    private void Update()
    {
        /*
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
        */
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

       
        if (gameObject.CompareTag("Good"))
        {
            score.UpdateScore(Random.Range(10,30)); 
            Instantiate(explode, transform.position, transform.rotation);
        }

        if (gameObject.CompareTag("Bad"))
        {
            score.GameOver();
        }
    }
}
