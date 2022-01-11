using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PadreBotones : MonoBehaviour
{
    [SerializeField] UnityEvent OnButtonPressed;
    [SerializeField] Material steppedMaterial;

    protected void ActivateButton()
    {
        OnButtonPressed?.Invoke();
        GetComponent<MeshRenderer>().material = steppedMaterial;
    }
}
