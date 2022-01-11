using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPortal : MonoBehaviour
{
    private int count = 2;

    public void SubstractCounter()
    {
        count--;
        if (count <= 0)
        {
            gameObject.SetActive(true);
        }
    }
}
