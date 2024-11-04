using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAnimator : MonoBehaviour
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

  
    void Update()
    {
        _timer += 0.01f;
        if (_timer >= _framerate)
        {
            _timer -= _framerate;
            _currentFrame = (_currentFrame + 1) % frameArray.Length;

            renderer.sprite = frameArray[_currentFrame];
        }
    }
}
