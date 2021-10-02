using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisibilityReaction : MonoBehaviour
{
    [SerializeField]private List<GameObject> goals;
    public MoveRobScr move;
    public abstract void SetGoal(GameObject _goal);
    public abstract void UpdateMoveTarget();
}
