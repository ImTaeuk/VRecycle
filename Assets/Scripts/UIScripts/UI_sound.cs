using UnityEngine;
using UnityEngine.UI;

public class UI_sound : MonoBehaviour
{
    public AudioClip clickSound; // 클릭 사운드 AudioClip
    private Button button; // Unity UI 버튼

    private AudioSource audioSource; // 사운드 재생을 위한 AudioSource

    void Start()
    {
        button = GetComponent<Button>(); // 버튼 컴포넌트 가져오기
        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트 가져오기

        // 버튼 클릭 이벤트에 사운드 재생 함수 연결
        button.onClick.AddListener(PlayClickSound);
    }

    void PlayClickSound()
    {
        // 클릭 사운드 재생
        audioSource.PlayOneShot(clickSound);
    }
}