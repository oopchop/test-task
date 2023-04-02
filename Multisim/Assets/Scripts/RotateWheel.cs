using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateWheel : MonoBehaviour
{
    private void OnMouseOver()
    {
        float wheelScroll = Input.GetAxis("Mouse ScrollWheel");

        if (wheelScroll > 0)
        {
            RollTypes(-45f);
        }
        else if (wheelScroll < 0)
        {
            RollTypes(45f);
        }
    }

    private void RollTypes(float zRotation)
    {
        Vector3 rotationPos = new Vector3(0f, 0f, zRotation);
        
        transform.Rotate(rotationPos);
    }
}
