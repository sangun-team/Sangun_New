using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineManager : MonoBehaviour
{
    public TimelineAsset[] timelines;
    public PlayableDirector pd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            pd.playableAsset = timelines[0];
            pd.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pd.playableAsset = timelines[1];
            pd.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            pd.playableAsset = timelines[2];
            pd.Play();
        }
    }
}
