using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentHandler : MonoBehaviour
{
    [SerializeField] float _speed;
    Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _rb.AddForce(-transform.up * _speed * Time.deltaTime);
        if(transform.position.y <= -15f)
        {
            Destroy(gameObject);
        }
    }
}
