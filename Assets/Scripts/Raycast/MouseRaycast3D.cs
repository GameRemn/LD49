using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseRaycast3D : MonoBehaviour
{
    public Camera camera;
    public bool updateRaycast;
    public KeyCode key;
    public UnityEvent<RaycastHit> onRaycastEvent;
    public UnityEvent<RaycastHit> onMissEvent;

    public void Update()
    {
        if (updateRaycast)
        {
            if (key == KeyCode.None)
            {
                Cust();
            }
            else if (Input.GetKey(key))
            {
                Cust();
            }
        }
        else
        {
            if (Input.GetKeyDown(key))
            {
                Cust();
            }
        }
    }

    void Cust()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            onRaycastEvent?.Invoke(hit);
        }
        else
        {
            onMissEvent?.Invoke(hit);
        }
    }
}
