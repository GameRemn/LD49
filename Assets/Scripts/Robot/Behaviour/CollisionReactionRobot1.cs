using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot1 : MonoBehaviour
{
    public Robot robot;
    public VisibilityReactionRobot1 visibilityReactionRobot1;
    public Timer timer;

    public void Reaction(GameObject goal)
    {
        if (visibilityReactionRobot1.goals.Contains(goal))
        {
            var goalRobot = goal.GetComponent<Robot>();
            if (goalRobot && !visibilityReactionRobot1.wait)
            {
                goalRobot.Death();
                visibilityReactionRobot1.wait = true;
                timer.StartTimer();
            }
        }
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        Reaction(other.gameObject);
    }
}
