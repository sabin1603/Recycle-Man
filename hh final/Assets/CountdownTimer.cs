using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 120f;
    [SerializeField] Text countdownText;


    private void Start()
    {
        currentTime = startingTime;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        countdownText.color = Color.green;
        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
            countdownText.color = Color.red;
        }
        if (currentTime <= 0)
        {
            PlayGame();
        }
    }
}
