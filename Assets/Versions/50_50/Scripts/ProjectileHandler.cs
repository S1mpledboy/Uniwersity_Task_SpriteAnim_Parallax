using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    [SerializeField] protected GameObject hitEffect;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float projectileSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.up * projectileSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            GameObject vfx = Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            Destroy(vfx, 1f);
            Destroy(gameObject);
        }   
    }
    
}
