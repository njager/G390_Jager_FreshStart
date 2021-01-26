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
    private float timer = 10;
    private string sceneName;
    private AudioSource audioSource;
    private AudioClip goneSFX;

    //start is called at the beginning of the game
    private void Start()
    {
        SetCountText();
        Scene scene = SceneManager.GetActiveScene();
        print(scene.name);
        sceneName = scene.name;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         if(itemsLeft <= 0)
        {
            if(sceneName == "level1")
            {
                SceneManager.LoadScene(2);
            }
            else if(sceneName == "level2")
            {
                SceneManager.LoadScene(3);
            }
            else if(sceneName == "level3")
            {
                SceneManager.LoadScene(4);
            }
        }

         if(timer <= 0)
        {
            SceneManager.LoadScene(4);
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
            audioSource.Play();
        }
    }
}
