using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public UI_Active_Manager uiController; // UIController 스크립트를 가진 오브젝트

    public int targetUIIndex; // 이동할 UI의 인덱스

    private Button button; // Unity UI 버튼

    void Start()
    {
        button = GetComponent<Button>(); // 버튼 컴포넌트 가져오기

        // 버튼 클릭 이벤트에 이동 함수 연결
        button.onClick.AddListener(MoveToUI);
    }

    void MoveToUI()
    {
        uiController.MoveUI(targetUIIndex);
    }
}
