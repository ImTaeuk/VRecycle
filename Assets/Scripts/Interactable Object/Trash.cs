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
    protected bool isCleard = false;

    [SerializeField] protected TrashType type;
}
