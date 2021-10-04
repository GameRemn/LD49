using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Events;

public class RobotsCounter : MonoSingleton<RobotsCounter>
{
    public IntReference robotsCount;
    public IntReference redRobotsCount;
    public IntReference blueRobotsCount;
    public IntReference wildRobotsCount;
    public int minWinValue;
    public UnityEvent winEvent;
    public UnityEvent offWinEvent;
    public BoolReference hardMod;
    public Timer timer;
    private bool timerOn;
    private void Start()
    {
        robotsCount.Value = 0;
        redRobotsCount.Value = 0;
        blueRobotsCount.Value = 0;
        wildRobotsCount.Value = 0;
    }

    public void AddRobotCount(int number)
    {
        robotsCount.Value += number;
        WinCheck();
    }
    
    public void AddRedRobotCount(int number)
    {
        redRobotsCount.Value += number;
        WinCheck();
    }
    
    public void AddBlueRobotCount(int number)
    {
        blueRobotsCount.Value += number;
        WinCheck();
    }

    public void AddWildRobotsCount(int number)
    {
        wildRobotsCount.Value += number;
        WinCheck();
    }

    public void WinCheck()
    {
        if (!hardMod.Value)
        {
            if (redRobotsCount.Value == blueRobotsCount.Value && redRobotsCount.Value > minWinValue &&
                blueRobotsCount.Value > minWinValue)
            {
                if (!timerOn)
                {
                    timerOn = true;
                    timer.StartTimer();
                    winEvent?.Invoke();
                }
            }
            else
            {
                if (timerOn)
                {
                    timerOn = false;
                    timer.StopTimer();
                    offWinEvent?.Invoke();
                }
            }
        }
        else
        {
            if (redRobotsCount.Value == blueRobotsCount.Value && blueRobotsCount.Value == wildRobotsCount.Value &&
                redRobotsCount.Value == wildRobotsCount.Value && redRobotsCount.Value > minWinValue &&
                blueRobotsCount.Value > minWinValue && wildRobotsCount.Value > minWinValue)
            {
                if (!timerOn)
                {
                    timerOn = true;
                    timer.StartTimer();
                    winEvent?.Invoke();
                }
            }
            else
            {
                if (timerOn)
                {
                    timerOn = false;
                    timer.StopTimer();
                    offWinEvent?.Invoke();
                }
            }
        }
    }
}
