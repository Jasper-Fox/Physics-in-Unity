using UnityEngine;

public class AddForceComponent : MonoBehaviour
{
    public Vector3 Force;
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        _rigidbody.AddForce(Force, ForceMode.VelocityChange);
    }

   
}
