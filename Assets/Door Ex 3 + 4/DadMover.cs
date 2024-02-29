using UnityEngine;

public class DadMover : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public Vector3 Force;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _rigidbody.AddForce(Force, ForceMode.Impulse);
    }
}
