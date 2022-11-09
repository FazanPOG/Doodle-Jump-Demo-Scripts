using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private float _movement;
    private Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _movement * _speed;
        _rb.velocity = velocity;
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y >= 0f)
        {
            
            if (_rb != null)
            {
                Vector2 velocity = _rb.velocity;
                velocity.y = _jumpForce;
                _rb.velocity = velocity;
            }
        }
    }
}
