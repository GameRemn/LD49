using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionArea : MonoBehaviour
{
    public UnityEvent<GameObject> onCollisionEnterEvent;
    public UnityEvent<GameObject> onCollisionExitEvent;
    public List<GameObject> collisionObjects;
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        var otherObj = other.gameObject;
        if (!collisionObjects.Contains(otherObj))
        {
            collisionObjects.Add(otherObj);
            onCollisionEnterEvent?.Invoke(otherObj);
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        var otherObj = other.gameObject;
        if (collisionObjects.Contains(otherObj))
        {
            collisionObjects.Remove(otherObj);
            onCollisionExitEvent?.Invoke(otherObj);
        }
    }
}
