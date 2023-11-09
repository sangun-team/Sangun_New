using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    public GameObject[] animal;
    public GameObject[] animals;
    float currentTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= 44)
        {
            // �迭�� �ִ� ��� GameObject���� �ϳ��� Destroy�ϱ�
            foreach (GameObject animal in animal)
            {
                Destroy(animal);
            }
        }
        if (currentTime >= 55)
        {
            // animals �迭�� �ִ� ��� GameObject���� �ϳ��� Destroy�ϱ�
            foreach (GameObject animals in animals)
            {
                Destroy(animals);
            }
        }

    }
}
