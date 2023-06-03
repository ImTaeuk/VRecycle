using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCan : Trash
{
    [SerializeField]  Material mat;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        mat.SetFloat("_Val", 150f);   
    }

    public override void OnActiveInteraction()
    {
        Debug.Log("B" + mat.GetFloat("_Val"));
        mat.SetFloat("_Val", 10);
        Debug.Log("A" + mat.GetFloat("_Val"));
        isCleared = true;
    }
}
