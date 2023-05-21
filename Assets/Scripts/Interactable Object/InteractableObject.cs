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
    protected Animator anim;
    [SerializeField] protected AudioSource sound;

    protected bool isAnimPlaying = false;

    protected ControllerManager manager;
    public void SetControllerManager(ControllerManager m) 
    {
        manager = m;
    } 


    public virtual void Awake()
    {
        anim= GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        manager = null;
    }

    public abstract void OnActiveInteraction();

    public void OnEndOfAnim()
    {
        isAnimPlaying= false;
    }
}
