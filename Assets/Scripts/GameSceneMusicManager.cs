using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

public class GameSceneMusicManager : MonoSingleton<GameSceneMusicManager>
{
    public AudioSource audioSource;
    public IntReference robotsCount;
    public List<IntMusic> intMusicsList;

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = NextAudioClip();
            audioSource.Play();
        }
    }

    public AudioClip NextAudioClip()
    {
        foreach (var intMusic in intMusicsList)
        {
            if (robotsCount.Value <= intMusic.count)
            {
                return intMusic.audioClip;
            }
        }

        return intMusicsList[intMusicsList.Count - 1].audioClip;
    }
}

[System.Serializable]
public class IntMusic
{
    public int count;
    public AudioClip audioClip;
}
