using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMa : MonoBehaviour
{
    float currentTime = 0;
    public float sceneTime = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= sceneTime)
        {
            SceneManager.LoadScene("PSW_Story");
        }
    }
}
