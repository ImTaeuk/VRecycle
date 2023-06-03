using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    [SerializeField] private bool isGrabbing;
    [SerializeField] private bool isTriggerActivated;
    public bool IsTriggerActivated => isTriggerActivated;

    private XRGrabInteractable grabbingObj;
    public XRGrabInteractable GetGrabbingObject => grabbingObj;

    private XRBaseInteractable interactingObj;
    public XRBaseInteractable GetInteractingObject => interactingObj;

    [SerializeField] float radius;

    Collider[] grabCols;
    Collider[] interactCols;

    [SerializeField] bool drawSphere = false;

    public float btnTimer = 0;


    private void Awake()
    {
        grabCols = new Collider[1];
        interactCols = new Collider[1];
    }


    private void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        UpdateInputTriggers();

        UpdateGrbbingObject();
        UpdateInteractObject();

        UpdateInteractableObjectState();

        UIRaycastProcess();

        if (btnTimer > 0)
            btnTimer -= Time.deltaTime;
    }

    void UIRaycastProcess()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        
        RaycastHit hit;
        
        if (GameManager.instance.UIActiveStatus && Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red);
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("UI"))
            {

                GameManager.instance.dot.transform.position = hit.point;
                Debug.Log(hit.transform.name);
                if (isTriggerActivated && btnTimer <= 0)
                {
                    Button btn = hit.transform.GetComponent<Button>();
                    if (btn != null)
                    {
                        btnTimer = 0.2f;
                        btn.onClick.Invoke();
                    }
                }
            }
        }
    }

    void UpdateInputTriggers()
    {
        isGrabbing = (gripAnimationAction.action.ReadValue<float>() == 0 ? false : true);
        isTriggerActivated = (pinchAnimationAction.action.ReadValue<float>() == 0 ? false : true);
    }

    private void OnDrawGizmos()
    {
        if (!drawSphere) return;

        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, radius);
    }

    private void UpdateGrbbingObject()
    {
        grabCols = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Interactable"));

        if (!isGrabbing || grabCols.Length == 0)
        {
            InteractableObject obj = null;

            if (grabbingObj != null && grabbingObj.TryGetComponent<InteractableObject>(out obj))
                obj.SetControllerManager(null);

            grabbingObj = null;

            return;
        }
        

        grabbingObj = grabCols[0].GetComponent<XRGrabInteractable>();
    }

    private void UpdateInteractObject()
    {
        interactCols = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Interactable"));

        if (!isTriggerActivated || interactCols.Length == 0)
        {
            InteractableObject obj = null;

            if (interactingObj != null && interactingObj.TryGetComponent<InteractableObject>(out obj))
                obj.SetControllerManager(null);

            interactingObj = null;
            return;
        }

        interactingObj = interactCols[0].GetComponent<XRBaseInteractable>();
    }


    private void UpdateInteractableObjectState()
    {
        InteractableObject obj;

        //Grab Object�� ����
        if (grabbingObj != null && grabbingObj.TryGetComponent<InteractableObject>(out obj) && grabbingObj)
        {
            obj.SetControllerManager(this);

            #region TO-DO: �Է¿� ���� State ���� ���� => ��Ʈ�ѷ� ���̽�ƽ �����¿� �Է� ���� ���� �б� + ��Ʈ�ѷ� pinch Ʈ���� �Է� �� (�Է� �޾��� ��, �� �� ��)�� ���� �б� �ʿ�
            //if ()
            #endregion
        }

        //Interact Object �� ����
        if (interactingObj != null && interactingObj.TryGetComponent<InteractableObject>(out obj) && isTriggerActivated)
        {
            obj.SetControllerManager(this);

            #region TO-DO: �Է¿� ���� State ���� ���� => ��Ʈ�ѷ� ���̽�ƽ �����¿� �Է� ���� ���� �б� + ��Ʈ�ѷ� pinch Ʈ���� �Է� �� (�Է� �޾��� ��, �� �� ��)�� ���� �б� �ʿ�
            //if ()
            #endregion
        }
    }

}
