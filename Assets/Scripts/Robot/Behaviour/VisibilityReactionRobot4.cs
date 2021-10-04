using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityReactionRobot4 : VisibilityReaction
{
    public bool wait;
    public override void AddGoal(GameObject _goal)
    {
        var _goalRobot = _goal.GetComponent<Robot>();
        if (_goalRobot)
        {
            if (_goalRobot.Fraction == robot.Fraction)
            {
                goals.Add(_goal);
            }
        }
    }

    public override void UpdateMoveTarget()
    {
        var robotPosition = transform.position;
        var rez = Vector3.zero;
        foreach (var goal in goals)
        {
            var moveVector3 = goal.transform.position - robotPosition;
            if (rez == Vector3.zero || rez.magnitude > moveVector3.magnitude)
                rez = moveVector3;
        }
        move.Move(robotPosition + rez);
    }

    public void Update()
    {
        if (goals.Count > 0 && !wait)
        {
            UpdateMoveTarget();
        }
        else
        {
            move.Move(transform.position);
        }
    }

    public void ResetWait()
    {
        wait = false;
    }
}
