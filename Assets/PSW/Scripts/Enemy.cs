using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public enum State
    {
        Idle,
        Move,
    }
    // ����
    public State state;
    // �̵� �ӵ�
    public float speed = 5;
    // �Ѿư� ���
    public GameObject target;
    // AI ����
    NavMeshAgent agent;
    // �ִϸ��̼�
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Idle: UpdateIdle(); break;
            case State.Move: UpdateMove(); break;
        }
    }

    private void UpdateIdle()
    {
        // �¾ �� ������(�÷��̾�)�� ã�� �ʹ�.
        target = GameObject.Find("Player");
        // ���� �������� ã�Ҵٸ� target != null
        if (target != null) 
        {
            // �̵� ���·� �����ϰ� �ʹ�.
            state = State.Move;
        }
    }

    private void UpdateMove()
    {
        // agent�� ���� �������� target(Player)�� ��ġ��
        agent.destination = target.transform.position;
        // �������� ���� �Ÿ��� ��� �ʹ�.
        float distance = Vector3.Distance(this.transform.position, target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // anim ����
            anim.SetTrigger("Wall");
            Destroy(this, 5);
        }
    }
}