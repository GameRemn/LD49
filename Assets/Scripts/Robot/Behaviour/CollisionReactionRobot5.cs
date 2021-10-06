using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot5 : MonoBehaviour
{
    public Robot robot; 
    public VisibilityReactionRobot5 visibilityReactionRobot5;
    public Timer timer;

    public void Reaction(GameObject goal)
    {
        if (visibilityReactionRobot5.goals.Contains(goal))
        {
            var goalRobot = goal.GetComponent<Robot>();
            if (goalRobot && !visibilityReactionRobot5.wait)
            {
                goalRobot.Death();
                visibilityReactionRobot5.wait = true;
                timer.StartTimer();
            }
        }
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        Reaction(other.gameObject);
    }
}
