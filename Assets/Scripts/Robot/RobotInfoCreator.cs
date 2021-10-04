using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotInfoCreator : MonoSingleton<RobotInfoCreator>
{
    [SerializeField] private RobotInfo nowRobot;
    [SerializeField] private RobotInfo nextRobot;

    public ObjectSpawn objectSpawn;

    public void Start()
    {
        nowRobot = RobotInfoList.Instance.RandomRobotInfo();
        nowRobot.robotMouseSprite.SetActive(true);
        objectSpawn.spawnObj = nowRobot.robotObject;
        nextRobot = RobotInfoList.Instance.RandomRobotInfo();
        nextRobot.robotSprite.SetActive(true);
    }

    public void ResetRobot()
    {
        nowRobot.robotMouseSprite.SetActive(false);
        nextRobot.robotSprite.SetActive(false);
        nowRobot = nextRobot;
        nowRobot.robotMouseSprite.SetActive(true);
        objectSpawn.spawnObj = nowRobot.robotObject;
        nextRobot = RobotInfoList.Instance.RandomRobotInfo();
        nextRobot.robotSprite.SetActive(true);
    }
}
