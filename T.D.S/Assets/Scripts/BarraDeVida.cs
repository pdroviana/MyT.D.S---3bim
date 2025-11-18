using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    
    public Inimigo inimigo;
    [SerializeField]
    private int vidasRestantes = 0;
    
  
    void Start()
    {
        if (inimigo != null && sliderVidasRestantes != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = inimigo.getVida();
        }
    }

    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = inimigo.getVida();
            sliderVidasRestantes.value = vidasRestantes;
        }
        
    }
}
