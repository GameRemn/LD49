using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pause;

    public void ResetPause()
    {
        if (pause)
        {
            PauseOff();
        }
        else
        {
            PauseOn();
        }
    }

    public void PauseOn()
    {
        Time.timeScale = 0;
        pause = true;
    }

    public void PauseOff()
    {
        Time.timeScale = 1;
        pause = false;
    }
}
