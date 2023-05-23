using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanRingBins : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name + " " + collision.gameObject.layer + " " + LayerMask.GetMask("Interactable"));
        if ( (1 << collision.gameObject.layer) == LayerMask.GetMask("Interactable"))
        {

            if(collision.transform.name.Contains("Ring"))
            {
                //TO-DO: 올바르게 캔뚜껑만 넣은 경우 추가 점수 부여하도록 하기
            }
            else
            {
                //TO-DO: 올바르지 않게 캔뚜껑만 넣은 경우 감점 부여하도록 하기
            }

            collision.gameObject.SetActive(false);
        }
    }
}
