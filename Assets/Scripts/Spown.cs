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
        MouseScr.mouseScr.SpriteV(robot[nomer].robotSprite);
        Debug.Log($"nomer: {nomer}");
    }
    void Update()
    {


        RaycastHit ray;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ray))
            {
                Vector3 MsPos = ray.point;
            CreatRobot(MsPos);
            CreatRobIm();
            }

            Debug.Log("GetMouseButtonDown0");
        }
        //if (Input.GetMouseButtonDown(1))////////////////////////////test
        //{
        //    movepast.GetComponent<MoveRobScr>().Move(MsPos);
        //    Debug.Log("GetMouseButtonDown1");
        //}
    }
    

    void CreatRobot(Vector3 startPos)
    {
        movepast=Instantiate(robot[nomer].robotObj, startPos, Quaternion.identity);
    }


}
