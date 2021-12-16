using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Coin : MonoBehaviour
{
    public UnityEvent<Coin> onChestCollision;
    private Rigidbody _rigidbody;
    private Vector3 _startPosition;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startPosition = transform.position;
    }
    public void ToStartPosition()
    {
        _rigidbody.isKinematic = true;
        transform.position = _startPosition;
    }
}
