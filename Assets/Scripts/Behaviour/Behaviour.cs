using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviour : MonoBehaviour
{
    [SerializeField]private List<Robot> goals;
    //public скрипт движения;
    public abstract void SetGoal(Robot _goal);
    public abstract void UpdateMoveTarget();
}
