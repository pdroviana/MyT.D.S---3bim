using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PainelDeVida : MonoBehaviour
{
   
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergia;
    
    
    
    void Start()
    {
        
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getVida();
        
        
        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
        
        
    }

   
    void Update()
    {
        
        sliderVidas.value = personagem.getVida();
        sliderEnergia.value = personagem.getEnergia();

        if (personagem.getVida() == 0)
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
