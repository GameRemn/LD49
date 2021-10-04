using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class Robot : MonoBehaviour
{
    public GameEventBase onEnableEvent;
    public GameEventBase onDisableEvent;
    public UnityEvent<Fraction> onFractionChange;
    public Fraction Fraction
    {
        get => _fraction;
        set => _fraction = value;
    }

    [SerializeField]private Fraction _fraction;

    public BehaviourType BehaviourType
    {
        get => _behaviourType;
        set => _behaviourType = value;
    }

    [SerializeField]private BehaviourType _behaviourType;

    public void OnEnable()
    {
        onEnableEvent?.Raise();
    }

    public void OnDisable()
    {
        onDisableEvent?.Raise();
    }

    public void Anigilation()
    {
        gameObject.SetActive(false);
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
