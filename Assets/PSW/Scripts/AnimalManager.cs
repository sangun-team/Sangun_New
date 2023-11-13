using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{ 
    public GameObject[] animals;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // animals 배열에 있는 모든 GameObject들을 하나씩 Destroy하기
            foreach (GameObject animals in animals)
            {
                print("동물들아 없어져라!");
                Destroy(animals);
            }
        }

    }
}
