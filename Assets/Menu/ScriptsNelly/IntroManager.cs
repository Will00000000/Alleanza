using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public string Menu; // Nome da próxima cena

    void Start()
    {
        VideoPlayer video = GetComponent<VideoPlayer>();
        video.loopPointReached += LoadNextScene;
    }

    void LoadNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }
}
