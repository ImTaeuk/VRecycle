using UnityEngine;
using UnityEngine.UI;

public class UI_sound : MonoBehaviour
{
    public AudioClip clickSound; // Ŭ�� ���� AudioClip
    private Button button; // Unity UI ��ư

    private AudioSource audioSource; // ���� ����� ���� AudioSource

    void Start()
    {
        button = GetComponent<Button>(); // ��ư ������Ʈ ��������
        audioSource = GetComponent<AudioSource>(); // AudioSource ������Ʈ ��������

        // ��ư Ŭ�� �̺�Ʈ�� ���� ��� �Լ� ����
        button.onClick.AddListener(PlayClickSound);
    }

    void PlayClickSound()
    {
        // Ŭ�� ���� ���
        audioSource.PlayOneShot(clickSound);
    }
}