using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Directional Light ã��
        directionalLight = GetComponent<Light>();

        if (directionalLight == null)
        {
            Debug.LogError("Directional Light�� ã�� �� �����ϴ�.");
        }
    }

    Light directionalLight;
    public float intensityAmount = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            directionalLight.intensity += intensityAmount;
        }
    }
}
