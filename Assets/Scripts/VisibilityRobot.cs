using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityRobot : Robot
{
    public VisibilityArea visibilityArea;
    public Behaviour behaviour;

    public void CheckVisibility(GameObject lastVisibilityObj)
    {
        var lastVisibilityRobot = lastVisibilityObj.GetComponent<Robot>();
        if(lastVisibilityRobot)
            behaviour.SetGoal(lastVisibilityRobot);
    }
}
