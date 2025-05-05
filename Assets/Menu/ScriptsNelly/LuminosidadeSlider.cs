using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class Brightness : MonoBehaviour
{
    public static Brightness Instance; // Singleton

    public Slider brightnessSlider;
    public PostProcessProfile brightnessProfile; // Perfil de Pós-Processamento
    public PostProcessLayer layer;
    public Camera mainCamera;

    private AutoExposure exposure;
    private const string BrightnessPref = "BrightnessValue";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém o objeto ao trocar de cena
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        if (brightnessProfile != null)
        {
            brightnessProfile.TryGetSettings(out exposure);
        }

        float savedBrightness = PlayerPrefs.GetFloat(BrightnessPref, 1f);

        if (brightnessSlider != null)
        {
            brightnessSlider.value = savedBrightness;
            brightnessSlider.onValueChanged.AddListener(AdjustBrightness);
        }

        AdjustBrightness(savedBrightness);
        ApplyPostProcessingToCamera();
    }

    private void ApplyPostProcessingToCamera()
    {
        // Encontra a câmera da nova cena
        mainCamera = Camera.main;

        if (mainCamera != null)
        {
            PostProcessVolume volume = mainCamera.GetComponent<PostProcessVolume>();

            if (volume == null)
            {
                volume = mainCamera.gameObject.AddComponent<PostProcessVolume>();
            }

            volume.sharedProfile = brightnessProfile; // Mantém o perfil de pós-processamento
        }
    }

    public void AdjustBrightness(float value)
    {
        if (exposure != null)
        {
            exposure.keyValue.value = value > 0 ? value : 0.05f;
        }

        PlayerPrefs.SetFloat(BrightnessPref, value);
        PlayerPrefs.Save();
    }

    private void OnLevelWasLoaded(int level)
    {
        ApplyPostProcessingToCamera();
    }
}
