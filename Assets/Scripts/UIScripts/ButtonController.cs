using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public UI_Active_Manager uiController; // UIController ��ũ��Ʈ�� ���� ������Ʈ

    public int targetUIIndex; // �̵��� UI�� �ε���

    private Button button; // Unity UI ��ư

    void Start()
    {
        button = GetComponent<Button>(); // ��ư ������Ʈ ��������

        // ��ư Ŭ�� �̺�Ʈ�� �̵� �Լ� ����
        button.onClick.AddListener(MoveToUI);
    }

    void MoveToUI()
    {
        uiController.MoveUI(targetUIIndex);
    }
}
