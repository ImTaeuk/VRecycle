using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUser : MonoBehaviour
{
    public Transform player; // ����� ��ġ ������ ���� �÷��̾� Transform
    public Transform uiElement; // �տ� �����Ǵ� UI ����� Transform

    void Update()
    {
        // ������� ��ġ�� ������ ������� UI ����� ��ġ ���
        Vector3 uiPosition = player.position + player.forward * 2.0f; // ����ڷκ��� �� 2���� �տ� ����

        // UI ����� ȸ���� ������� ����� ��ġ��Ŵ
        Quaternion uiRotation = Quaternion.LookRotation(player.forward);

        // UI ����� ��ġ�� ȸ�� ������Ʈ
        uiElement.position = uiPosition;
        uiElement.rotation = uiRotation;
    }
}
