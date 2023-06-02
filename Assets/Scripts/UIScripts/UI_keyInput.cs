using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
public class UI_keyInput : MonoBehaviour
{
    public GameObject uiObject; // 끄거나 켤 UI 요소
    public KeyCode toggleKey = KeyCode.B; // B 키로 설정

    private void Update()
    {
        // VR 컨트롤러 버튼 입력 감지
        if (CheckToggleButton())
        {
            ToggleUI();
        }
    }

    private bool CheckToggleButton()
    {
        // 키보드 입력 감지
        if (Input.GetKeyDown(toggleKey))
        {
            return true;
        }
        return false;
    }

    private void ToggleUI()
    {
        // UI 요소 활성화/비활성화 전환
        uiObject.SetActive(!uiObject.activeSelf);
    }
}