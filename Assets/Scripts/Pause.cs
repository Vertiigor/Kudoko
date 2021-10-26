using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    static public bool isPaused = false;
    [SerializeField] Text pauseText;

    public void PauseGame()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            pauseText.text = "Paused";
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
            pauseText.text = "";
        }
    }
}
