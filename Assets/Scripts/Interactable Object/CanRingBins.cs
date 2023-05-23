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
                //TO-DO: �ùٸ��� ĵ�Ѳ��� ���� ��� �߰� ���� �ο��ϵ��� �ϱ�
            }
            else
            {
                //TO-DO: �ùٸ��� �ʰ� ĵ�Ѳ��� ���� ��� ���� �ο��ϵ��� �ϱ�
            }

            collision.gameObject.SetActive(false);
        }
    }
}
