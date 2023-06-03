using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Can : Trash
{
    [SerializeField] Transform ring;

    bool isCrushed = false;

    private MeshFilter meshFilter;

    [SerializeField] private Mesh crushed;
    [SerializeField] private Mesh origin;


    protected override void Awake()
    {
        base.Awake();
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Update()
    {
        if (manager != null && !isCrushed && manager.IsTriggerActivated)
            OnActiveInteraction();
    }

    public override void OnActiveInteraction()
    {
        isCleared= true;
        isCrushed = true;
        ring.SetParent(ring.parent.parent);
        meshFilter.mesh = crushed;
        sound.Play();
        ring.AddComponent<Rigidbody>();
        ring.AddComponent<BoxCollider>();
    }


}
