using UnityEngine;
using System.Collections;

public class RedPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
