using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private void Awake()
    {
        ControlVolume(1);
    }


    [SerializeField] AudioSource click;
    public void PlayClickSound()
    {
        click.Play();
    }

    float volume;

    public void ControlVolume(float val)
    {
        volume = val;

        foreach(var itr in audioSources)
        {
            itr.volume = volume;
        }
    }

    [SerializeField] private List<AudioSource> audioSources;
    [SerializeField] private AudioSource success;
    public void PlaySuccessSound()
    {
        success.Play();
    }
    [SerializeField] private AudioSource failure;
    public void PlayFailureSound()
    {
        failure.Play();
    }

    [SerializeField] private AudioSource inGameBGM;
    public void PlayInGameBGM(bool val)
    {
        if (val)
            inGameBGM.Play();
        else
            inGameBGM.Stop();
    }
}
