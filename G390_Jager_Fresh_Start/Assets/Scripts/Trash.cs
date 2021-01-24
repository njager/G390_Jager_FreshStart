using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Trash : MonoBehaviour
{
    //public variables
    public int itemsLeft;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI timerText;

    //private variables
    private float timer =20;

    //start is called at the beginning of the game
    private void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
         if(itemsLeft <= 0)
        {
            print("Done!");
        }

        timer -= Time.deltaTime;
        timerText.text = "Time left = " + timer.ToString();
    }

    void SetCountText()
    {
        countText.text = "Items left to donate = " + itemsLeft.ToString();
    }

    //detects collision with item
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            print("CollidedTrig");
            itemsLeft -= 1;
            other.gameObject.SetActive(false);
            SetCountText();
        }
    }
}
