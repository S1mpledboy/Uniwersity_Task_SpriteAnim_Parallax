using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimater : MonoBehaviour
{
    [SerializeField] Sprite[] frameArray;
    int _currentFrame;
    float _timer;
    [SerializeField] float _framerate = 0.1f;
    SpriteRenderer renderer;
    
    void Awake()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += 0.01f;// 0.1f - random value from my head. Correct code is _timer += Time.deltaTime, but it`s using Time
        if (_timer >= _framerate)
        {
            _timer -= _framerate;
            _currentFrame = (_currentFrame + 1) % frameArray.Length;
            
            renderer.sprite = frameArray[_currentFrame];
        }
    }
}
