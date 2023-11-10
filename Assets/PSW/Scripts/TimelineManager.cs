using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Video;

public class TimelineManager : MonoBehaviour
{
    public TimelineAsset[] timelines;
    public PlayableDirector pd;

    public AudioSource[] bgm;

    public GameObject mideaArtCam;

    public VideoPlayer video1; // 그림 설명 1
    public VideoPlayer video2; // 그림 설명 2
    public VideoPlayer video3; // 그림 설명 3

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mideaArtCam.SetActive(true);
            video1.Play();
            video2.Stop();
            video3.Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[0].Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            mideaArtCam.SetActive(false);
            pd.playableAsset = timelines[0];
            pd.Play();
            video1.Stop();
            video2.Stop();
            video3.Stop();
            bgm[0].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[1].Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            mideaArtCam.SetActive(true);
            video1.Stop();
            video3.Stop();
            video2.Play();
            bgm[0].Stop();
            bgm[1].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[2].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            mideaArtCam.SetActive(false);
            pd.playableAsset = timelines[1];
            pd.Play();
            video1.Stop();
            video2.Stop();
            video3.Stop();
            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[3].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            mideaArtCam.SetActive(true);
            video1.Stop();
            video2.Stop();
            video3.Play();
            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[5].Stop();
            bgm[4].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            mideaArtCam.SetActive(false);
            pd.playableAsset = timelines[2];
            pd.Play();
            video1.Stop();
            video2.Stop();
            video3.Stop();
            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Play();
        }
    }
}
