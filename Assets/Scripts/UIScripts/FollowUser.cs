using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUser : MonoBehaviour
{
    public Transform player; // 사용자 위치 추적을 위한 플레이어 Transform
    public Transform uiElement; // 앞에 고정되는 UI 요소의 Transform

    void Update()
    {
        // 사용자의 위치와 방향을 기반으로 UI 요소의 위치 계산
        Vector3 uiPosition = player.position + player.forward * 2.0f; // 사용자로부터 약 2미터 앞에 고정

        // UI 요소의 회전을 사용자의 방향과 일치시킴
        Quaternion uiRotation = Quaternion.LookRotation(player.forward);

        // UI 요소의 위치와 회전 업데이트
        uiElement.position = uiPosition;
        uiElement.rotation = uiRotation;
    }
}
