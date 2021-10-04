using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventTriggerBase<T> : MonoBehaviour where T : IEquatable<T> 
{
    public List<ValueEvent<T>> valueEvents;

    public void CheckEvents(T value)
    {
        foreach (var valueEvent in valueEvents)
        {
            if (value.Equals(valueEvent.value))
            {
                valueEvent.gameEvent?.Invoke();
            }
        }
    }
}
