using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ValueEvent<T>
{
    public T value;
    public UnityEvent gameEvent;
}
