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
            // 배열에 있는 모든 GameObject들을 하나씩 Destroy하기
            foreach (GameObject animal in animal)
            {
                Destroy(animal);
            }
        }
        if (currentTime >= 55)
        {
            // animals 배열에 있는 모든 GameObject들을 하나씩 Destroy하기
            foreach (GameObject animals in animals)
            {
                Destroy(animals);
            }
        }

    }
}
