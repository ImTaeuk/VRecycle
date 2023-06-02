using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
public class UI_keyInput : MonoBehaviour
{
    public GameObject uiObject; // ���ų� �� UI ���
    public KeyCode toggleKey = KeyCode.B; // B Ű�� ����

    private void Update()
    {
        // VR ��Ʈ�ѷ� ��ư �Է� ����
        if (CheckToggleButton())
        {
            ToggleUI();
        }
    }

    private bool CheckToggleButton()
    {
        // Ű���� �Է� ����
        if (Input.GetKeyDown(toggleKey))
        {
            return true;
        }
        return false;
    }

    private void ToggleUI()
    {
        // UI ��� Ȱ��ȭ/��Ȱ��ȭ ��ȯ
        uiObject.SetActive(!uiObject.activeSelf);
    }
}