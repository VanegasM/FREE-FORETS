using UnityEngine;

public class BasicController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float horizontal;
    private float vertical;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        _rigidbody.velocity = new Vector3(horizontal * _speed, _rigidbody.velocity.y , vertical * _speed);
    }
}
