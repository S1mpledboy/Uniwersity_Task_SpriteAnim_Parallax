using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmpPosition : MonoBehaviour
{
    [SerializeField] float yMax, xMax;
    private void LateUpdate()
    {
        CalmpPositionOfObject();
    }
    void CalmpPositionOfObject()
    {
        float calmpedY = Mathf.Clamp(transform.position.y, -yMax, yMax);
        float calmpedX = Mathf.Clamp(transform.position.x, -xMax, xMax);
        if (Mathf.Abs(transform.position.y) >= yMax || Mathf.Abs(transform.position.x) >= xMax)
        {
            transform.position = new Vector3(calmpedX, calmpedY, transform.position.z);
        }
    }
}
