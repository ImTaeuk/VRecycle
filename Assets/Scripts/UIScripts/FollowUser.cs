using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUser : MonoBehaviour
{
    public Transform playerTransform; // 플레이어의 위치를 따라가야 할 트랜스폼

    private void Update()
    {
        if (playerTransform != null)
        {
            // 플레이어의 위치를 UI의 위치로 설정
            transform.position = playerTransform.position;
        }
    }
}