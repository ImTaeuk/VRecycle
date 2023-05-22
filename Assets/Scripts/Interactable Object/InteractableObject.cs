using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 해당 오브젝트를 상속하여 가위나 칼과 같은 오브젝트를 구현하도록한다.
/// 핵심은 OnActiveInteraction 함수를 오버라이드 하여 해당 물체가 사용되는 애니메이션 및 상호작용으로 일어나는 효과를 구현하도록한다.
/// </summary>
/// 
public abstract class InteractableObject : MonoBehaviour
{
    protected Animator anim;
    protected AudioSource sound;

    protected bool isAnimPlaying = false;
    public bool IsAnimPlaying => isAnimPlaying;

    protected ControllerManager manager;
    public ControllerManager getManager;

    public void SetControllerManager(ControllerManager m) 
    {
        manager = m;
    } 


    protected virtual void Awake()
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
