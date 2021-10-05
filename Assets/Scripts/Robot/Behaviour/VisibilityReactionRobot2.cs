using UnityEngine;

public class VisibilityReactionRobot2 : VisibilityReaction
{
    public float distance;
    public override void AddGoal(GameObject _goal)
    {
        var _goalRobot = _goal.GetComponent<Robot>();
        if (_goalRobot)
        {
            if (_goalRobot.BehaviourType == BehaviourType.Aggressive && _goalRobot.Fraction != robot.Fraction)
            {
                goals.Add(_goal);
            }
        }
    }

    public override void UpdateMoveTarget()
    {
        var rez = Vector3.zero;
        var robotPosition = robot.transform.position;
        foreach (var goal in goals)
        {
            var moveVector3 = robotPosition - goal.transform.position;
            moveVector3 *= distance - moveVector3.magnitude;
            rez += moveVector3;
        }
        move.Move(robotPosition + rez);
    }

    public void Update()
    {
        if (goals.Count > 0)
        {
            UpdateMoveTarget();
        }
        else
        {
            move.Move(transform.position);
        }
    }
}
