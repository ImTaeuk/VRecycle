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
    ControllerManager manager;
    public void SetControllerManager(ControllerManager m) { manager = m; } 


    public virtual void Awake()
    {
        anim= GetComponent<Animator>();
        manager = null;
    }

    public abstract void OnActiveInteraction();
}
