using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    float horizontalMvement, vercticalMovement;
    [SerializeField] float shipSpeed, firerate;
    [SerializeField] GameObject projecTile;
    [SerializeField] Transform rocketSilo1, rocketSilo2;// yeah yeah it`s trash naming, but good enough
    float _timer;
    Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Shoot()
    {
        Instantiate(projecTile, rocketSilo1.position, rocketSilo1.rotation);
        Instantiate(projecTile, rocketSilo2.position, rocketSilo2.rotation);
    }

    void Update()
    {
        horizontalMvement = Input.GetAxis("Horizontal");
        vercticalMovement = Input.GetAxis("Vertical"); 
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(horizontalMvement, vercticalMovement) * shipSpeed;
        _timer += 0.1f;
        if(_timer >= firerate)
        {
            _timer -= firerate;
            Shoot();
        }
    }
}
