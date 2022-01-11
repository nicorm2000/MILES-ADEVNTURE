using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerController : MonoBehaviour
{
    [SerializeField] UnityEvent OnTriggerExitEvents;
    [SerializeField] UnityEvent OnTriggerEnterEvents;
    [SerializeField] string[] tagsToUse;


    private bool CheckTag(string otherTag)
    {
        foreach (string tag in tagsToUse) 
        {
            if (tag == otherTag)
            {
                return true;
            }
        }
        return false;
    }
    public void OnTriggerExit(Collider other)
    {
        if (CheckTag(other.tag))
        {
            OnTriggerExitEvents?.Invoke();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (CheckTag(other.tag))
        {
            OnTriggerEnterEvents?.Invoke();
        }
    }
}
