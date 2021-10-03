using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spown : MonoBehaviour
{
    public List<RobotSpownS> robot;
    int nomer;
    GameObject movepast;////////////////////////////test
    void Start()
    {
        CreatRobIm();
    } 
    void CreatRobIm()
    {
        nomer = Random.Range(0, robot.Count);
        Debug.Log(MouseScr.mouseScr.t);
        MouseScr.mouseScr.SpriteV(robot[nomer].robotSprite);
        Debug.Log($"nomer: {nomer}");
    }
    void Update()
    {
        Vector3 MsPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        MsPos.z = 0;        
        if (Input.GetMouseButtonDown(0))
        {
            CreatRobot(MsPos);
            CreatRobIm();
            Debug.Log("GetMouseButtonDown0");
        }
        if (Input.GetMouseButtonDown(1))////////////////////////////test
        {
            movepast.GetComponent<MoveRobScr>().Move(MsPos);
            Debug.Log("GetMouseButtonDown1");
        }
        MouseScr.mouseScr.FollowMouse(MsPos);
    }
    
    void CreatRobot(Vector3 startPos)
    {
        movepast=Instantiate(robot[nomer].robotObj, startPos, Quaternion.identity);
    }


}
