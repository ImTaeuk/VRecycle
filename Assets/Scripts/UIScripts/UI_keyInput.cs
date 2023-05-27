using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class UI_keyInput : MonoBehaviour
{
    public GameObject canvas; // UI ĵ���� ���� ������Ʈ
    public XRNode inputSource;

    private bool isGripPressed = false;

    private void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);

        if (device.TryGetFeatureValue(CommonUsages.gripButton, out bool gripValue))
        {
            if (gripValue && !isGripPressed)
            {
                canvas.SetActive(!canvas.activeSelf); // UI ĵ������ Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
                isGripPressed = true;
            }
            else if (!gripValue && isGripPressed)
            {
                isGripPressed = false;
            }
        }
    }
}
