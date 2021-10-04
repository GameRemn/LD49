using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spown : MonoBehaviour
{
    public List<RobotInfo> robot;
    int nomer;
    void Start()
    {
        CreatRobIm();
    } 
    void CreatRobIm()
    {
        nomer = Random.Range(0, robot.Count);
    }

    public void SpownRobot()
    {
        Vector3 MsPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MsPos.z = 0;
        CreatRobot(MsPos);
        CreatRobIm();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    void CreatRobot(Vector3 startPos)
    {
        
    }
}
