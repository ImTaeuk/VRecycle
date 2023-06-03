using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TrashType
{
    can,
    plastic,
    vinyl,
    styrofoam,
    glass,
    other,
}

public class Trash : InteractableObject
{
    public bool isCleared = false;
    public bool IsCleared => isCleared;

    [SerializeField] protected TrashType type;
    public TrashType GetTrashType() { return type; }

    public override void OnActiveInteraction()
    {
        //do nothing
    }
}
