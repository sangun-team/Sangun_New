using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // ���� �ð�
    float currentTime;
    // ���� �ð�
    public float makeTime = 1;
    // �� ����
    public GameObject[] enemyFactory;
  
    // Update is called once per frame
    void Update()
    {
        // �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // ���� ���� �ð��� ���� �ð��� �Ǹ�
        if (currentTime > makeTime)
        {
            // �������� �� ���� �迭���� �ϳ��� ����
            int randomIndex = Random.Range(0, enemyFactory.Length);
            // �����忡�� ���� ����
            GameObject enemy = Instantiate(enemyFactory[randomIndex]);
            // �� ��ġ�� ��ġ�ϰ� �ʹ�.
            enemy.transform.position = transform.position;
            // ���� �ð��� 0���� �ʱ�ȭ �ϰ� �ʹ�.
            currentTime = 0;
        }
    }
}
