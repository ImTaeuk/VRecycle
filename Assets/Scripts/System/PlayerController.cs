using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;


    // TO-DO: Grab 상태인 오브젝트를 알아내는 방법을 모름
    InteractableObject grabObject;

    private void Update()
    {
        PlayerMove();

    }


    private void UseInteractableObject()
    {
        grabObject.OnActiveInteraction();
    }


    private void PlayerMove()
    {
        if (Input.GetButton(""))
        {
            // TO-DO: 오큘러스 Input 입력 함수에 따른 이동 구현 -> 이동을 RigidBody VS transform.translate 
        }
    }
}
