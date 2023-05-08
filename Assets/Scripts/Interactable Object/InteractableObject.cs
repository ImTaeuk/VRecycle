using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ش� ������Ʈ�� ����Ͽ� ������ Į�� ���� ������Ʈ�� �����ϵ����Ѵ�.
/// �ٽ��� OnActiveInteraction �Լ��� �������̵� �Ͽ� �ش� ��ü�� ���Ǵ� �ִϸ��̼� �� ��ȣ�ۿ����� �Ͼ�� ȿ���� �����ϵ����Ѵ�.
/// </summary>
/// 
public abstract class InteractableObject : MonoBehaviour
{
    Animator anim;

    public virtual void Awake()
    {
        anim= GetComponent<Animator>();
    }

    public abstract void OnActiveInteraction();
}
