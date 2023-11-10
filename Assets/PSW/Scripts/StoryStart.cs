using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryStart : MonoBehaviour
{
    public UnityEngine.UI.Image fade;
    float fades = 1f;
    float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (fades > 0f && time >= 0.1f)
        {
            fades -= 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }
        else if (fades <= 0f)
        {
            time = 0;
        }
    }
}
