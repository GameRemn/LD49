using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Events;

public class Robot : MonoBehaviour
{
    public GameEventBase onEnableEvent;
    public GameEventBase onDisableEvent;
    public UnityEvent<Fraction> onFractionChange;
    public Robot goal;
    public Fraction Fraction
    {
        get => _fraction;
        set => _fraction = value;
    }

    [SerializeField]private Fraction _fraction;

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

public enum BehaviourType
{
    Aggressive,
    Peaceful
}
