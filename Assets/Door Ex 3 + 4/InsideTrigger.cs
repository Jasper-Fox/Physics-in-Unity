using UnityEngine;

public class InsideTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dad inside");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Dad outside(");
    }
}
