using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    private Vector3 _targetPosition;

    private void Update()
    {
        if (_playerTransform.position.y > transform.position.y) 
        {
            _targetPosition = new Vector3(_targetPosition.x, _playerTransform.position.y, -10f);
            transform.position = Vector3.Lerp(transform.position, _targetPosition, _speed * Time.deltaTime);
        }
    }
}
