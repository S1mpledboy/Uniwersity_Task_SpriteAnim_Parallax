using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _EnviromentObjectsList = new List<GameObject>();
    [SerializeField] List<GameObject> _SpawnPoints = new List<GameObject>();
    [SerializeField] float _spawnRate;
    float _timer;
    int _lastResult = 0;
    private void Start()
    {
        _timer = _spawnRate;
    }

    void Update()
    {
        _timer += 0.01f;
        if(_timer >= _spawnRate)
        {
            _timer = 0;
            int randomItemIndex = Random.Range(0, _EnviromentObjectsList.Count);
            
            int randomSpawnPoint = Random.Range(0, _SpawnPoints.Count);
            Instantiate(_EnviromentObjectsList[randomItemIndex], _SpawnPoints[randomSpawnPoint].transform.position, transform.rotation);
        }
    }
}
