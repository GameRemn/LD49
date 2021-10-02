using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class MoveRobScr : MonoBehaviour
{
    public float speed;    
    [SerializeField]
    private Animator anim;

    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Move (Vector3 finPos)
    {
        float timeMove = CountTime(finPos - transform.position);
        rigid.DOMove(finPos, timeMove);
    }

    float CountTime(Vector3 deltaPos)
    {
        float dx = deltaPos.x;
        float dy = deltaPos.y;
        float distanse = Mathf.Sqrt(dx * dx + dy * dy);
        return (distanse / speed);
    }
    void AnimationRobot()
    {

    }
}
