using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUser : MonoBehaviour
{
    public Transform playerTransform; // �÷��̾��� ��ġ�� ���󰡾� �� Ʈ������

    private void Update()
    {
        if (playerTransform != null)
        {
            // �÷��̾��� ��ġ�� UI�� ��ġ�� ����
            transform.position = playerTransform.position;
        }
    }
}