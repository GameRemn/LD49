using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScr : MonoBehaviour
{
    SpriteRenderer SpriteMouse;
    public static MouseScr mouseScr;
    public int t = 5;//////////////////////////////////////////////
        private void Awake()
    {
        mouseScr = this;
        SpriteMouse =GetComponent<SpriteRenderer>();
    }

    public void FollowMouse(Vector3 MsPos)
    {
        SpriteMouse.transform.position = MsPos;
    }

    public void SpriteV(Sprite robotImage)
    {
        SpriteMouse.sprite= robotImage;
    }
}
