using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{

    public int Respawn;

    public Transform PointA;
    public Transform PointB;
    public float speed;
    public Vector3 location;


    // Update is called once per frame
    void Update()
    {
        if (transform.position == PointA.position)
        {
            location = PointB.position;
        }
        else if (transform.position == PointB.position)
        {
            location = PointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, location, speed);
    }







       private void OnTriggerEnter2D(Collider2D other)
    {



        if (other.CompareTag("Player"))
        {
            Debug.Log("move to scene" + Respawn);
            SceneManager.LoadScene(Respawn);

        }
    }
}


