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
            // animals �迭�� �ִ� ��� GameObject���� �ϳ��� Destroy�ϱ�
            foreach (GameObject animals in animals)
            {
                print("������� ��������!");
                Destroy(animals);
            }
        }

    }
}
