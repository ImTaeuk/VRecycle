using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class UI_keyInput : MonoBehaviour
{
    public GameObject canvas; // UI 캔버스 게임 오브젝트
    public XRNode inputSource;

    private bool isGripPressed = false;

    private void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);

        if (device.TryGetFeatureValue(CommonUsages.gripButton, out bool gripValue))
        {
            if (gripValue && !isGripPressed)
            {
                canvas.SetActive(!canvas.activeSelf); // UI 캔버스를 활성화 또는 비활성화
                isGripPressed = true;
            }
            else if (!gripValue && isGripPressed)
            {
                isGripPressed = false;
            }
        }
    }
}
