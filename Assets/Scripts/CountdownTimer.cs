using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime <= 3)
            countdownText.color = Color.red;

        currentTime -= 1 * Time.deltaTime;

        countdownText.text = Mathf.Ceil(currentTime).ToString("0");

        if(currentTime < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            currentTime = 0;
        }
    }
}
