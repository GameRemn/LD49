using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{
    public UnityEvent<GameObject> onTriggerEnterEvent;
    public UnityEvent<GameObject> onTriggerExitEvent;
    public List<GameObject> triggerObjects;
    public void OnTriggerEnter2D(Collider2D other)
    {
        var otherObj = other.gameObject;
        if (!triggerObjects.Contains(otherObj))
        {
            triggerObjects.Add(otherObj);
            onTriggerEnterEvent?.Invoke(otherObj);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        var otherObj = other.gameObject;
        if (triggerObjects.Contains(otherObj))
        {
            triggerObjects.Remove(otherObj);
            onTriggerExitEvent?.Invoke(otherObj);
        }
    }
}
