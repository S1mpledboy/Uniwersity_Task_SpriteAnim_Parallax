using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazySpaceShipController : MonoBehaviour
{
    float horizontalMvement, vercticalMovement;
    [SerializeField] float shipSpeed, firerate, MaxX, MaxY;
    [SerializeField] GameObject projecTile;
    [SerializeField] List<Transform> rocketSilos = new List<Transform>();// yeah yeah it`s trash naming, but good enough
    float _timer;
    Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Shoot(List<Transform> spawnPointsOfProjectTiles)
    {
       foreach(Transform spawnPoints in spawnPointsOfProjectTiles)
        {
            Instantiate(projecTile, spawnPoints.position, spawnPoints.rotation);
        }
    }

    void Update()
    {
        horizontalMvement = Input.GetAxis("Horizontal");
        vercticalMovement = Input.GetAxis("Vertical"); 
    }
    private void FixedUpdate()
    {
        _rb.AddForce(new Vector2(horizontalMvement, vercticalMovement) * shipSpeed);
        
        _timer += Time.deltaTime;
        if(_timer >= firerate)
        {
            _timer -= firerate;
            Shoot(rocketSilos);
        }
    }

}
