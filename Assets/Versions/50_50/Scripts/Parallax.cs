using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Range(-1f, 1f)]
    [SerializeField] float scrollSpeed = 0.5f;
    [SerializeField] Renderer renderer;

    private void LateUpdate()
    {
        renderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }

}

