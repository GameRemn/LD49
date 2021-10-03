using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot4 : MonoBehaviour
{
    public Robot robot;
    public VisibilityReactionRobot4 visibilityReactionRobot4;
    public Timer timer;

    public void Reaction(GameObject goal)
    {
        if (visibilityReactionRobot4.goals.Contains(goal))
        {
            var goalRobot = goal.GetComponent<Robot>();
            if (goalRobot)
            {
                if (goalRobot.Fraction == robot.Fraction && !visibilityReactionRobot4.wait)
                {
                    Instantiate(goal, goal.transform.position, goal.transform.rotation);
                    visibilityReactionRobot4.wait = true;
                    timer.StartTimer();
                }
            }
        }
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        Reaction(other.gameObject);
    }
}
