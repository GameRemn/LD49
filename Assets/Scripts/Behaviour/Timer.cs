using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float delay;
    public UnityEvent doOnTimer;
    public bool onStart;
    public bool loop;
    Coroutine timer;
    void Start()
    {
        if(onStart)
            StartTimer();
    }

    public void StartTimer()
    {
        timer = StartCoroutine(EventTimer(delay, loop));
    }

    public void StopTimer()
    {
        Debug.Log("Stop");
        StopCoroutine(timer);
    }

    IEnumerator EventTimer(float _delay, bool _loop)
    {
        //Debug.Log("Dont stop");
        if (_loop)
        {
            while (_loop)
            {
                yield return new WaitForSeconds(_delay);
                doOnTimer?.Invoke();
            }
        }
        else
        {
            yield return new WaitForSeconds(_delay);
            doOnTimer?.Invoke();
        }
    }
}
