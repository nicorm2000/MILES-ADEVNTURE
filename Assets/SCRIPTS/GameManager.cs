using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform respawn;
    public Transform respawn2;
    public Transform tpPoint1;
    public Transform tpPoint2;
    public Transform tpPoint3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            gameObject.transform.position = respawn.position;
        }
        if (other.CompareTag("Lava2"))
        {
            gameObject.transform.position = respawn2.position;
        }
        if (other.CompareTag("Portal"))
        {
            gameObject.transform.position = tpPoint1.position;
        }
        if (other.CompareTag("Portal1"))
        {
            gameObject.transform.position = tpPoint2.position;
        }
        if (other.CompareTag("Portal2"))
        {
            gameObject.transform.position = tpPoint3.position;
        }
        if (other.CompareTag("PortalPurple"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
