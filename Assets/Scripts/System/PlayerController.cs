using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;


    // TO-DO: Grab ������ ������Ʈ�� �˾Ƴ��� ����� ��
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
            // TO-DO: ��ŧ���� Input �Է� �Լ��� ���� �̵� ���� -> �̵��� RigidBody VS transform.translate 
        }
    }
}
