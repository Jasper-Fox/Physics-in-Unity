using UnityEngine;


public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("GOAL!!!");
    }

    private void OnTriggerStay(Collider other)
    {
            Debug.Log("Was Goal!");
    }

    private void OnTriggerExit(Collider other)
    {
            Debug.Log("What..?");
    }
}
