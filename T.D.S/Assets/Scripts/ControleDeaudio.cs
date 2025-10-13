using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ControleDeaudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;
    public TMP_Text musicaText;
    
    public Slider volumeSlider;
    public Toggle musicaToggle;
    public Slider VolumeSFXSlider;
    void Start()
    {
        musica = musicaToggle.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)VolumeSFXSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        musica = musicaToggle.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)VolumeSFXSlider.value;


        if (musica == true)
        {
            musicaText.text = "Ligado";
            musicaText.color = Color.green;
        }


        else
        {
            musicaText.text = "Desligado";
            musicaText.color = Color.red;
        }
    }
}
