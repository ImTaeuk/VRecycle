using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    [SerializeField] private bool isGrabbing;
    [SerializeField] private bool isTriggerActivating;

    private XRGrabInteractable grabbingObj;
    public XRGrabInteractable GetGrabbingObject => grabbingObj;

    private XRBaseInteractable interactingObj;
    public XRBaseInteractable GetInteractingObject => interactingObj;

    [SerializeField] float radius;

    Collider[] grabCols;
    Collider[] interactCols;

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
    }


    void UpdateInputTriggers()
    {
        isGrabbing = (gripAnimationAction.action.ReadValue<float>() == 0 ? false : true);
        isTriggerActivating = (pinchAnimationAction.action.ReadValue<float>() == 0 ? false : true);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, radius);
    }

    private void UpdateGrbbingObject()
    {
        grabCols = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Interactable"));

        if (!isGrabbing || grabCols.Length == 0)
        {
            grabbingObj = null;
            return;
        }

        grabbingObj = grabCols[0].GetComponent<XRGrabInteractable>();
    }

    private void UpdateInteractObject()
    {
        interactCols = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Interactable"));

        if (!isTriggerActivating || interactCols.Length == 0)
        {
            interactingObj = null;
            return;
        }

        interactingObj = interactCols[0].GetComponent<XRBaseInteractable>();
    }


    private void UpdateInteractableObjectState()
    {
        InteractableObject obj;

        //Grab Object에 대해
        if (grabbingObj.TryGetComponent<InteractableObject>(out obj) && grabbingObj)
        {
            obj.SetControllerManager(this);

            #region TO-DO: 입력에 따른 State 변경 예정 => 컨트롤러 조이스틱 상하좌우 입력 값에 따른 분기 + 컨트롤러 pinch 트리거 입력 값 (입력 받았을 때, 땔 때 등)에 따른 분기 필요
            //if ()
            #endregion
        }

        //Interact Object 에 대해
        if (interactingObj.TryGetComponent<InteractableObject>(out obj) && isTriggerActivating)
        {
            obj.SetControllerManager(this);

            #region TO-DO: 입력에 따른 State 변경 예정 => 컨트롤러 조이스틱 상하좌우 입력 값에 따른 분기 + 컨트롤러 pinch 트리거 입력 값 (입력 받았을 때, 땔 때 등)에 따른 분기 필요
            //if ()
            #endregion
        }
    }

}
