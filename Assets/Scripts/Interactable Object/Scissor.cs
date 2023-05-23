using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissor : InteractableObject
{
    private void Update()
    {
        if (manager != null && manager.IsTriggerActivated)
            OnActiveInteraction();
    }

    public override void OnActiveInteraction()
    {
        if (isAnimPlaying)
            return;
        isAnimPlaying = true;
        Debug.Log("Active");
        anim.SetTrigger("activeTrigger");
        sound.Play();
    }
}
