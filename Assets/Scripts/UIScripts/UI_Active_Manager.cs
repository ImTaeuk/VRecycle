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

        // �ش� �ε����� UI �ѱ�
        uiElements[index].SetActive(true);

        // ���� ���
        audioSource.Play();
    }
}

//Any UI