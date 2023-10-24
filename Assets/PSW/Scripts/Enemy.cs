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
        Move
    }
    // 상태
    public State state;
    // 이동 속도
    public float speed = 5;
    // 쫓아갈 대상
    public GameObject target;
    // AI 설정
    NavMeshAgent agent;
    void Start()
    {
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
        // 태어날 때 목적지(플레이어)를 찾고 싶다.
        target = GameObject.Find("Player");
        // 만약 목적지를 찾았다면 target != null
        if (target != null) 
        {
            // 이동 상태로 전이하고 싶다.
            state = State.Move;
        }
    }

    private void UpdateMove()
    {
        // agent야 너의 목적지는 target(Player)의 위치야
        agent.destination = target.transform.position;
        // 목적지와 나의 거리를 재고 싶다.
        float distance = Vector3.Distance(this.transform.position, target.transform.position);
    }
}