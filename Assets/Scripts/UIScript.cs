using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public List<AudioSource> batAud1;
    public void SliderSettings(float value)
    {
        
    }
    public void RandomAud()
    {
        int i = Random.Range(0, batAud1.Count);
        batAud1[i].Play();
    }
}
