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

<<<<<<< HEAD
     Light directionalLight;
=======
    Light directionalLight;
>>>>>>> HDRP-New-Main
    public float intensityAmount = 0.1f;

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if(Input.GetKeyDown(KeyCode.Alpha5))
=======
        if (Input.GetKeyDown(KeyCode.Alpha5))
>>>>>>> HDRP-New-Main
        {
            directionalLight.intensity += intensityAmount;
        }
    }
}
