using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VisibilityArea : MonoBehaviour
{
    public UnityEvent<GameObject> onTriggerEnterEvent;
    public UnityEvent<GameObject> onTriggerExitEvent;
    public List<GameObject> visibilityObjects;
    public void OnTriggerEnter2D(Collider2D other)
    {
        var otherObj = other.gameObject;
        if (!visibilityObjects.Contains(otherObj))
        {
            visibilityObjects.Add(otherObj);
            onTriggerEnterEvent?.Invoke(otherObj);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        var otherObj = other.gameObject;
        if (visibilityObjects.Contains(otherObj))
        {
            visibilityObjects.Remove(otherObj);
            onTriggerExitEvent?.Invoke(otherObj);
        }
    }
}
