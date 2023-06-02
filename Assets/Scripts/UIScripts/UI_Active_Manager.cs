using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Active_Manager : MonoBehaviour
{

    public GameObject[] uiElements;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void MoveUI(int index)
    {
        foreach (GameObject uiElement in uiElements)
        {
            uiElement.SetActive(false);
        }

        // 해당 인덱스의 UI 켜기
        uiElements[index].SetActive(true);

        // 사운드 재생
        audioSource.Play();
    }
}

//Any UI