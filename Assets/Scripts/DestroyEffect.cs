using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(-45, 0, Random.Range(0f, 360f)));
        audioSource.clip = audioClips[Random.Range(0, audioClips.Count)];
        audioSource.Play();
    }
}
