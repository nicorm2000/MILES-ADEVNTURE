using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeButtons : MonoBehaviour
{
    private int count = 3; 

    public void SubstractCounter()
    {
        count--;
        if (count <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
