using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashbin : InteractableObject
{
    [SerializeField] private TrashType trashType;

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

    private void OnCollisionEnter(Collision collision)
    {
        Trash trash;
        if (collision.transform.TryGetComponent<Trash>(out trash))
        {
            if (trash.GetTrashType() == trashType)
            {
                GameManager.instance.SoundController.PlaySuccessSound();
            }
            else GameManager.instance.SoundController.PlayFailureSound();

            // trash type에 따라 점수 부여
            trash.gameObject.SetActive(false);
        }
    }

}
