using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollow : MonoBehaviour
{
    [Range(1.0f, 20.0f)] public float distance = 10;
    [Range(0.01f, 1.0f)] public float speed = 0.1f;
    
    private void Update()
    {
        // Input.mousePosition // Input Manager에서 마우스의 위치를 가져오는 방식
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        mousePosition.z = distance;
        Vector3 target = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = Vector3.Lerp(transform.position, target, speed);
    }
}
