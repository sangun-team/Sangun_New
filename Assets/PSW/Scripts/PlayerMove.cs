using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(-v, 0, h);
        // 벡터의 정규화
        dir.Normalize();

        Vector3 velocity = dir * speed;
        transform.position += velocity * Time.deltaTime;
    }
}
