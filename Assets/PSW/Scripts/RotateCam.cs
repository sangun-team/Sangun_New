using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에 따라 x와 y축의 회전을 하고 싶다.
public class RotateCam : MonoBehaviour
{
    float rx;
    float ry;
    // 회전 속도
    public float rotSpeed = 200;
   
    void Update()
    {
        // 사용자의 입력에 따라
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        // x와 y축 값을 누적하고
        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;
        // rx에 대해 각도를 제한하고 싶다.
        rx = Mathf.Clamp(rx, -75, 75);
        // 그 누적값으로 회전을 하고 싶다.
        transform.eulerAngles = new Vector3(-rx, ry, 0); 
    }
}
