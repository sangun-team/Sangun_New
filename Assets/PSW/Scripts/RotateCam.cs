using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� x�� y���� ȸ���� �ϰ� �ʹ�.
public class RotateCam : MonoBehaviour
{
    float rx;
    float ry;
    // ȸ�� �ӵ�
    public float rotSpeed = 200;
   
    void Update()
    {
        // ������� �Է¿� ����
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        // x�� y�� ���� �����ϰ�
        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;
        // rx�� ���� ������ �����ϰ� �ʹ�.
        rx = Mathf.Clamp(rx, -75, 75);
        // �� ���������� ȸ���� �ϰ� �ʹ�.
        transform.eulerAngles = new Vector3(-rx, ry, 0); 
    }
}
