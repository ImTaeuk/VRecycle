using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private List<AudioSource> audioSources;

    private void Awake()
    {
        audioSources = new List<AudioSource>();
    }

    /// <summary>
    /// audioName => GameConsts.AudioSourceName.이름 형식으로 사용
    /// </summary>
    /// <param name="audioName"></param>
    /// <param name="isLoop"></param>
    public void PlayAudioSource(string audioName, bool isLoop = false)
    {
        foreach (AudioSource itr in audioSources)
        {
            itr.Play();
        }
    }

    public void StopAudioSource(string audioName)
    {

    }
}
