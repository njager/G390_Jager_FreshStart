using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Collided");
    }
}
