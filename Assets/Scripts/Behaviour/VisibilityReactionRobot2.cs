using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityReactionRobot2 : VisibilityReaction
{
    public override void AddGoal(GameObject _goal)
    {
        var _goalRobot = _goal.GetComponent<Robot>();
        if (_goalRobot)
        {
            if(_goalRobot.BehaviourType == BehaviourType.Aggressive && _goalRobot.Fraction != robot.Fraction)
                goals.Add(_goal);
        }
    }

    public override void RemoveGoal(GameObject _goal)
    {
        if (goals.Contains(_goal))
            goals.Remove(_goal);
    }

    public override void UpdateMoveTarget()
    {
        var rez = Vector3.zero;
        var robotPosition = robot.transform.position;
        foreach (var goal in goals)
        {
            rez += robotPosition - goal.transform.position;
        }
        move.Move(robotPosition + rez);
    }

    public void FixedUpdate()
    {
        UpdateMoveTarget();
    }
}
