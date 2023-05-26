using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Active_Manager : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;

// Objectname.activeSelf = isActive;
    public void SetUI(GameObject Click,GameObject Get_Clicked)
    {
        Get_Clicked.SetActive(true);
        Click.SetActive(false);
    }

    public void Obj1_TO_Obj2()
    {
        SetUI(obj1, obj2);
    }

}

//Any UI