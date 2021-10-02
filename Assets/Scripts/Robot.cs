using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Events;

public abstract class Robot : MonoBehaviour
{
    public GameEventBase onEnableEvent;
    public GameEventBase onDisableEvent;
    public UnityEvent<Fraction> onFractionChange;
    public Fraction Fraction
    {
        get => _fraction;
        set => _fraction = value;
    }

    private Fraction _fraction;

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

public enum Fraction
{
    Red,
    Blue,
    Neutral
}
