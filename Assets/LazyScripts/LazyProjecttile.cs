using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyProjecttile : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player")) return;
        GameObject explosionEffect =  Instantiate(hitEffect, transform.position, transform.rotation);
        Destroy(explosionEffect, 1f);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
