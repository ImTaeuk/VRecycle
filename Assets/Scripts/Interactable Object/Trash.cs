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
}

public abstract class Trash : InteractableObject
{
    protected bool isCleared = false;
    public bool IsCleared => isCleared;

    [SerializeField] protected TrashType type;
    public TrashType GetTrashType() { return type; }
}
