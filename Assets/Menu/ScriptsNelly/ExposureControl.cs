using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class ExposureControl : MonoBehaviour
{
    public Volume volume;
    public Slider exposureSlider;

    private ColorAdjustments colorAdjustments;

    void Start()
    {
        // Tenta pegar o override do perfil de volume
        if (volume.profile.TryGet<ColorAdjustments>(out colorAdjustments))
        {
            // Atualiza valor inicial do slider (opcional)
            exposureSlider.value = colorAdjustments.postExposure.value;

            // Conecta o método ao evento do slider
            exposureSlider.onValueChanged.AddListener(UpdateExposure);
        }
        else
        {
            Debug.LogError ("ColorAdjustments não encontrados no Volume Profile!");
        }
    }

    void UpdateExposure(float value)
    {
        if (colorAdjustments != null)
        {
            colorAdjustments.postExposure.overrideState = true; // FORÇA ativação
            colorAdjustments.postExposure.value = value;
        }
    }
}
