//Class is for the door

using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    private int nextSceneToLoad;//the number of the next level in Scenes in Build
    public bool isInRange;

    /**
    *   Method to move to the next level
    *   Is called when player "interacts" with the door
    */
    public void NextLevel()
    {
         nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;//gets the number of the next level
         SceneManager.LoadScene(nextSceneToLoad);//loads in the next level
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
