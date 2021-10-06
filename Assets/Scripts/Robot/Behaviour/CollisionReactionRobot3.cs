using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot3 : MonoBehaviour
{
    public Robot robot; 
    public VisibilityReactionRobot3 visibilityReactionRobot3;
    public Timer timer;

    public void Reaction(GameObject goal)
    {
        if (visibilityReactionRobot3.goals.Contains(goal))
        {
            var goalRobot = goal.GetComponent<Robot>();
            if (goalRobot && !visibilityReactionRobot3.wait)
            {
                goalRobot.Death();
                visibilityReactionRobot3.wait = true;
                timer.StartTimer();
            }
        }
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        Reaction(other.gameObject);
    }
}
