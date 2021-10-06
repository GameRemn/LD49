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
    }

    [SerializeField]private BehaviourType _behaviourType;

    public void OnEnable()
    {
        RobotsCounter.Instance.AddRobotCount(1);
        if(_fraction == Fraction.Blue)
            RobotsCounter.Instance.AddBlueRobotCount(1);
        else if(_fraction == Fraction.Red)
            RobotsCounter.Instance.AddRedRobotCount(1);
        else if(_fraction == Fraction.Neutral)
            RobotsCounter.Instance.AddWildRobotsCount(1);
        onEnableEvent?.Raise();
    }

    public void OnDisable()
    {
        RobotsCounter.Instance.AddRobotCount(-1);
        if(_fraction == Fraction.Blue)
            RobotsCounter.Instance.AddBlueRobotCount(-1);
        else if(_fraction == Fraction.Red)
            RobotsCounter.Instance.AddRedRobotCount(-1);
        else if(_fraction == Fraction.Neutral)
            RobotsCounter.Instance.AddWildRobotsCount(-1);
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
