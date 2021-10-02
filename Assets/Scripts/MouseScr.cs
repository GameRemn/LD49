using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScr : MonoBehaviour
{
    SpriteRenderer SpriteMouse;
    public static MouseScr mouseScr;

    private void Awake()
    {
        mouseScr = this;
        SpriteMouse =GetComponent<SpriteRenderer>();
    }

    public void FollowMouse(Vector3 MsPos)
    {
        SpriteMouse.transform.position = MsPos;
    }

    public void SpriteV(SpriteRenderer robotImage)
    {
        SpriteMouse = robotImage;
    }
}
