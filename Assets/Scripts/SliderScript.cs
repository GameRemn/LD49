using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SliderScript : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup valueMus;
    [SerializeField] private AudioMixerGroup valueEff;

    public void MusSetg(float valuePlay)
    {
        valueMus.audioMixer.SetFloat("Mus", Mathf.Lerp(-80, 0, valuePlay));
        Debug.Log($"Music:   {Mathf.Lerp(-80, 0, valuePlay)}");
    }
    public void EffectSetg(float valuePlay)
    {
        valueEff.audioMixer.SetFloat("Eff", Mathf.Lerp(-80, 0, valuePlay));
        Debug.Log($"Value:   {valuePlay}    Effect:   {Mathf.Lerp(-80, 0, valuePlay)}");
    }
}
