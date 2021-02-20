using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_Paused_Always_17 : MonoBehaviour
{
    bool isPaused = false;
    public void pausegame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }    



}
