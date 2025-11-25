using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    [Header("Mixer")]
    public AudioMixer mixer;

    [Header("UI")]
    public TMP_Text musicaText;
    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle musicaToggle;

    private void Start()
    {
        // Inicializa texto do toggle
        AtualizarTextoMusica(musicaToggle.isOn);

        // Adiciona eventos
        volumeSlider.onValueChanged.AddListener(AlterarVolumeMusica);
        volumeSFXSlider.onValueChanged.AddListener(AlterarVolumeSFX);
        musicaToggle.onValueChanged.AddListener(AtualizarTextoMusica);
    }

    private void AlterarVolumeMusica(float v)
    {
        mixer.SetFloat("Musica", Mathf.Lerp(-80, 0, v)); 
    }

    private void AlterarVolumeSFX(float v)
    {
        mixer.SetFloat("SFX", Mathf.Lerp(-80,  0,v)); 
    }

    private void AtualizarTextoMusica(bool ligado)
    {
        if (ligado)
        {
            musicaText.text = "Ligado";
            musicaText.color = Color.green;
            mixer.SetFloat("Musica", 0);
        }
        else
        {
            musicaText.text = "Desligado";
            musicaText.color = Color.red;
            mixer.SetFloat("Musica", -80); // Mudo
        }
    }
}