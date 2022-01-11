using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicklUp : MonoBehaviour
{
    public Camera camaraPrimeraPersona;
    public GameObject handPoint;
    private bool boolSoltar;
    private Object obj;

    private void Start()
    {
        boolSoltar = false;
    }

    void Update()

    {
        if (Input.GetKeyDown("e") && boolSoltar == false)
        {
            Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 4f) && hit.collider.gameObject.TryGetComponent(out obj))
            {
                obj.GetComponent<Rigidbody>().useGravity = false;

                obj.GetComponent<Rigidbody>().isKinematic = true;

                obj.transform.position = handPoint.transform.position;

                obj.transform.SetParent(handPoint.gameObject.transform);

                boolSoltar = true;
            }
        }

        else if (Input.GetKeyDown("e") && boolSoltar)
        {
            obj.GetComponent<Rigidbody>().useGravity = true;

            obj.GetComponent<Rigidbody>().isKinematic = false;

            obj.transform.SetParent(null);

            boolSoltar = false;
        }
    }
}