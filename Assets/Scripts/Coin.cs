using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Coin : MonoBehaviour
{
    public UnityEvent<Coin> onChestCollision;
    private Rigidbody _rigidbody;
    private Vector3 _startPosition;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
        _startPosition = transform.position;
        transform.Rotate(90, 0, 0);
    }
    public void ToStartPosition()
    {
        _rigidbody.isKinematic = true;
        transform.position = _startPosition;
    }
    public void Fall(Vector3 position)
    {
        transform.position = position;
        _rigidbody.isKinematic = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Chest>())
            onChestCollision?.Invoke(this);
    }
}
