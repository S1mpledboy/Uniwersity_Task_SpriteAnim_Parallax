using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxNoAuto : MonoBehaviour
{
    Vector2 currentPosition, lastPosition, positionDefference;
    bool parralaxNow;
    [SerializeField] float speed;
    private void LateUpdate()
    {
        if (parralaxNow == true)
        {
            DetectCameraMovement();
            transform.Translate(new Vector3(positionDefference.x, positionDefference.y, 0) * speed * Time.deltaTime, Space.World);
            
        }
    }
    void DetectCameraMovement()
    {
        currentPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
        if (currentPosition == lastPosition)
        {
            positionDefference = Vector2.zero;
        }
        else
        {
            positionDefference = currentPosition - lastPosition;
        }
        lastPosition = currentPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            lastPosition = currentPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
            parralaxNow = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            parralaxNow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            positionDefference = Vector2.zero;
            parralaxNow = false;
        }
    }
}
