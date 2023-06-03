using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkWater : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        FoodCan fc;
        if (other.TryGetComponent<FoodCan>(out fc))
        {
            Debug.Log("123");
            fc.OnActiveInteraction();
        }
    }
}
