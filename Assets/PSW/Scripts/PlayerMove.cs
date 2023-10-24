using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 이동 속도
    public float speed = 10;

    // 회전 속도
    public float rotateSpeed = 10f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(-v, 0, h);
        // 벡터의 정규화
        dir.Normalize();

        // 바라보는 방향으로 회전 후 다시 정면으로 바라보는 현상을 막기 위한 것
        if (!(h == 0 && v == 0))
        {
            // 이동과 회전을 함께 처리
            transform.position += dir * speed * Time.deltaTime;
            // 회전하는 부분
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }
        //Vector3 velocity = dir * speed;
        //transform.position += velocity * Time.deltaTime;
    }
}
