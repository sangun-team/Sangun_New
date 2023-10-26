using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // 현재 시간
    float currentTime;
    // 생성 시간
    public float makeTime = 1;
    // 적 공장
    public GameObject[] enemyFactory;
  
    // Update is called once per frame
    void Update()
    {
        // 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 만약 현재 시간이 생성 시간이 되면
        if (currentTime > makeTime)
        {
            // 랜덤으로 적 공장 배열에서 하나를 선택
            int randomIndex = Random.Range(0, enemyFactory.Length);
            // 적공장에서 적을 만들어서
            GameObject enemy = Instantiate(enemyFactory[randomIndex]);
            // 내 위치에 배치하고 싶다.
            enemy.transform.position = transform.position;
            // 현재 시간을 0으로 초기화 하고 싶다.
            currentTime = 0;
        }
    }
}
