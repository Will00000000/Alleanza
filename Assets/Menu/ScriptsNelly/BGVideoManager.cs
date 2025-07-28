using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class BGVideoManager: MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;

    void Start()
    {
        //videoPlayer.source = VideoSource.Url;
        //videoPlayer.url = Application.streamingAssetsPath + "/Video2Loop.mp4"; //provisório para futura aplicação

        videoPlayer.isLooping = true;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.None;

        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += (vp) =>
        {
            rawImage.texture = vp.targetTexture;
            videoPlayer.Play();
        };
    }
}