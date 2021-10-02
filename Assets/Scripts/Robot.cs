using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

public abstract class Robot : MonoBehaviour
{
    public GameEventBase onEnableEvent;
    public GameEventBase onDisableEvent;

    public void OnEnable()
    {
        onEnableEvent.Raise();
    }

    public void OnDisable()
    {
        onDisableEvent.Raise();
    }

    public void Anigilation()
    {
        Destroy(gameObject);
    }
}
