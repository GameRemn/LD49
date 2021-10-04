using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Audio;

public class UIScript : MonoBehaviour
{
    //[SerializeField] private List<AudioMixerGroup> valueAud;

    //public void MuseSetg(float valuePlay)
    //{
    //    valueAud[0].audioMixer.SetFloat("Music",Mathf.Lerp(-80,0,valuePlay));
    //}
    //public void EffectSetg(float valuePlay)
    //{
    //    valueAud[1].audioMixer.SetFloat("Effects",Mathf.Lerp(-80,0,valuePlay));
    //}
    public void MenuRandomAud(AudioSource batAud)
    {
        batAud.pitch=Random.Range(0.9f, 1.1f);
        batAud.Play();
    }
    public void MusicStart(AudioSource batAud)
    {
        batAud.Play();
    }
    public void Pause()//
    {
        Time.timeScale = 0;
    }
    public void Resume()//
    {
        Time.timeScale = 1;
    }
    public void Exite()
    {
        Application.Quit();
    }
 //public void MenuRandomAud()
    //{
    //    int i = Random.Range(0, batAud.Count);
    //    batAud[i].Play();
    //} 
    

}
