using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillerDoor : MonoBehaviour
{
    public bool isInRange;

    /**
    *   Method to move to the next level
    *   Is called when player "interacts" with the door
    */
    public void NextLevel()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        if (isInRange)
        {
            NextLevel();
        }
    }

    // detect if the player has entered the collider (isTrigger is true) of the interactable object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    // detect if the player has exited the collider (isTrigger is true) of the interactable object
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
