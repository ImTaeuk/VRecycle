using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Trash
{
    private bool isCollisionOnScissor;

    Scissor scissor;

    [SerializeField] Material labelMaterial;

    bool isShaderChanged = false;

    [SerializeField] float speed;

    float val = -0.7f;

    bool cutted = false;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        labelMaterial.SetFloat("_Val", -0.7f);
    }

    private void Update()
    {
        OnActiveInteraction();
        if (isShaderChanged && (cutted || (scissor != null && scissor.IsAnimPlaying)) && transform.GetChild(0).gameObject.activeSelf)
        {
            isCleared= true;
            cutted = true;
            Debug.Log(labelMaterial.GetFloat("_Val"));
            if (val >= 0.5f) transform.GetChild(0).gameObject.SetActive(false);
            val += Time.deltaTime * speed;
            labelMaterial.SetFloat("_Val", val);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent<Scissor>(out scissor))
        {
            isCollisionOnScissor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.GetComponent<Scissor>() != null)
        {
            isCollisionOnScissor = false;
            scissor = null;
        }
    }

    public override void OnActiveInteraction()
    {
        if (scissor == null) return;

        isShaderChanged = true;
    }
}
