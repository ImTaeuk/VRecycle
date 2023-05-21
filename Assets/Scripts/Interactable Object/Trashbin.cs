using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashbin : InteractableObject
{
    private bool isPlayerAttached = false;

    [SerializeField] bool drawGizmos = false;

    float animTimer = 0;

    private void Update()
    {
        OnActiveInteraction();
    }

    public override void OnActiveInteraction()
    {


        if (Vector3.Distance(Camera.main.gameObject.transform.position, transform.position + Vector3.up * 1.5f) <= 3)
        {
            if (!isPlayerAttached)
            {
                isPlayerAttached = true;
                sound.Play();
            }

            anim.SetBool("activeBool", true);
        }
        else
        {
            if (isPlayerAttached)
            {
                isPlayerAttached = false;
                sound.Play();
            }
            anim.SetBool("activeBool", false);
        }

        //anim.SetTrigger("activeTrigger");
    }
}
