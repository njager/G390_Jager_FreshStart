using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Trash : MonoBehaviour
{
    //public variables
    public int itemsLeft;
    

    //private variables
    private int count;

    // Update is called once per frame
    void Update()
    {
         if(itemsLeft <= 0)
        {
            print("Done!");
        }
    }

    //detects collision with item
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            print("CollidedTrig");
            itemsLeft -= 1;
            other.gameObject.SetActive(false);
        }
    }
}
