using UnityEngine;

public class Personagem : MonoBehaviour
{
    
    [SerializeField] int vidas;
    [SerializeField] public int energia;
    [SerializeField] public float velocidade;
    
    public void setVidas(int vidas)
    {
        this.vidas = vidas;
        
    }

    public int getVidas()
    {
        return this.vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
