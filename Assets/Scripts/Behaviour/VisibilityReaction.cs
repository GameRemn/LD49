using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisibilityReaction : MonoBehaviour
{
    public Robot robot;
    public List<GameObject> goals;
    public MoveRobScr move;
    
    public abstract void AddGoal(GameObject _goal);

    public void RemoveGoal(GameObject _goal)
    {
        if (goals.Contains(_goal))
            goals.Remove(_goal);
    }
    public abstract void UpdateMoveTarget();
}
