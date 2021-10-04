using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityReactionRobot7 : VisibilityReaction
{
    public bool wait;

    public List<GameObject> memory;
    public override void AddGoal(GameObject _goal)
    {
        if (!memory.Contains(_goal))
        {
            var _goalRobot = _goal.GetComponent<Robot>();
            if (_goalRobot)
            {
                if (_goalRobot.Fraction != robot.Fraction && _goalRobot.Fraction != Fraction.Neutral)
                {
                    goals.Add(_goal);
                }
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
    
    public void MemoryRemove(GameObject _gameObject)
    {
        if (memory.Contains(_gameObject))
            memory.Remove(_gameObject);
    }
}
