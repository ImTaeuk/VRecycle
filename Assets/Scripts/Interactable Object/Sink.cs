using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sink : InteractableObject
{
    private bool isPlayerAttached = false;

    [SerializeField] private bool drawGizmos = false;

    [SerializeField] private ParticleSystem ps;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Update()
    {
        CheckPlayerAttached();
        OnActiveInteraction();
    }

    void CheckPlayerAttached()
    {
        if (Vector3.Distance(Camera.main.gameObject.transform.position, transform.position + Vector3.up * 1.5f) <= 2)
        {
            if (!isPlayerAttached)
            {
                isPlayerAttached = true;
                sound.loop = true;
                sound.Play();
            }
        }
        else
        {
            if (isPlayerAttached)
            {
                isPlayerAttached = false;
                sound.Stop();
            }
        }
    }

    public override void OnActiveInteraction()
    {
        if (isPlayerAttached)
            ps.Play();
        else ps.Stop();
    }
}
