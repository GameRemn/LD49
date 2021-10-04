using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot7 : MonoBehaviour
{
    public Robot robot; 
    public VisibilityReactionRobot7 visibilityReactionRobot7;
    public Timer timer;

    public void Reaction(GameObject goal)
    {
        if (visibilityReactionRobot7.goals.Contains(goal))
        {
            var goalRobot = goal.GetComponent<Robot>();
            if (goalRobot && !visibilityReactionRobot7.wait)
            {
                goalRobot.gameObject.SetActive(false);
                if (goalRobot.Fraction == Fraction.Blue)
                    goalRobot.Fraction = Fraction.Red;
                else if (goalRobot.Fraction == Fraction.Red)
                {
                    goalRobot.Fraction = Fraction.Blue;
                }
                goalRobot.gameObject.SetActive(true);
                visibilityReactionRobot7.memory.Add(goal);
                visibilityReactionRobot7.wait = true;
                timer.StartTimer();
            }
        }
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        Reaction(other.gameObject);
    }
}
