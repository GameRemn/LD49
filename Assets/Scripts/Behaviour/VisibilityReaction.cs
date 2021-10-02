using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisibilityReaction : MonoBehaviour
{
    public Robot robot;
    [SerializeField]protected List<GameObject> goals;
    public MoveRobScr move;
    public abstract void AddGoal(GameObject _goal);
    public abstract void RemoveGoal(GameObject _goal);
    public abstract void UpdateMoveTarget();
}
