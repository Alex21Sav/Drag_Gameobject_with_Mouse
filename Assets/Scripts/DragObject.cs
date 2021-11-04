using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 _mouseOffSet;

    private float _mouseZCoord;
    private void OnMouseDown()
    {
        _mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        
        _mouseOffSet = gameObject.transform.position - GetMouseWorldPosition();
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = _mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() - _mouseOffSet;
    }
}
