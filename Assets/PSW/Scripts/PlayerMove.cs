using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �̵� �ӵ�
    public float speed = 10;

    // ȸ�� �ӵ�
    public float rotateSpeed = 10f;

    // animation
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(-h, 0, -v);
        // ������ ����ȭ
        dir.Normalize();

        // �ٶ󺸴� �������� ȸ�� �� �ٽ� �������� �ٶ󺸴� ������ ���� ���� ��
        if (!(h == 0 && v == 0))
        {
            // �̵��� ȸ���� �Բ� ó��
            transform.position += dir * speed * Time.deltaTime;
            // ȸ���ϴ� �κ�
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);

            // �ִϸ��̼� ����
            anim.SetBool("Idle", false);
            anim.SetBool("Run", true);
        }
        else if (h == 0 && v == 0)
        {
            // �ִϸ��̼� ����
            anim.SetBool("Run", false);
            anim.SetBool("Idle", true);
        }

        //Vector3 velocity = dir * speed;
        //transform.position += velocity * Time.deltaTime;
    }
}
