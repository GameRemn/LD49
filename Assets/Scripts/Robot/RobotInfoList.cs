using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotInfoList : MonoSingleton<RobotInfoList>
{
    public List<RobotInfo> robotInfoList;

    public RobotInfo RandomRobotInfo()
    {
        var index = Random.Range(0, robotInfoList.Count);
        return robotInfoList[index];
    }

    public RobotInfo FindRobotInfo(GameObject robot)
    {
        foreach (var robotInfo in robotInfoList)
        {
            if (robotInfo.robotObject == robot)
            {
                return robotInfo;
            }
        }

        return null;
    }
}
