using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;

public class TimelineManager : MonoBehaviour
{
    public TimelineAsset[] timelines;
    public PlayableDirector pd;

    public AudioSource[] bgm;

    public GameObject mideaArtCam;

    public VideoPlayer video;
    public VideoClip[] videoClips;
    public GameObject rawImage;
    public GameObject backImage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RenderTexture rt = new RenderTexture(1920, 1080, 24);
            rawImage.GetComponent<RawImage>().texture = rt;
            video.targetTexture = rt;
            video.clip = videoClips[0];
            video.Play();
            rawImage.SetActive(true);
            backImage.SetActive(true);

            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[0].Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            rawImage.SetActive(false);
            backImage.SetActive(false);
            video.Stop();
            pd.playableAsset = timelines[0];
            pd.Play();

            bgm[0].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[1].Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            RenderTexture rt = new RenderTexture(1920, 1080, 24);
            rawImage.GetComponent<RawImage>().texture = rt;
            video.targetTexture = rt;
            video.clip = videoClips[1];
            video.Play();
            rawImage.SetActive(true);
            backImage.SetActive(true);

            bgm[0].Stop();
            bgm[1].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[2].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rawImage.SetActive(false);
            backImage.SetActive(false);
            video.Stop();
            pd.playableAsset = timelines[1];
            pd.Play();

            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[4].Stop();
            bgm[5].Stop();
            bgm[3].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            RenderTexture rt = new RenderTexture(1920, 1080, 24);
            rawImage.GetComponent<RawImage>().texture = rt;
            video.targetTexture = rt;
            video.clip = videoClips[2];
            video.Play();
            rawImage.SetActive(true);
            backImage.SetActive(true);

            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[5].Stop();
            bgm[4].Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            rawImage.SetActive(false);
            backImage.SetActive(false);
            video.Stop();
            pd.playableAsset = timelines[2];
            pd.Play();

            bgm[0].Stop();
            bgm[1].Stop();
            bgm[2].Stop();
            bgm[3].Stop();
            bgm[4].Stop();
            bgm[5].Play();
        }
    }
}
