using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    public int vida;
    [SerializeField]
    private int energia;
    [SerializeField]
    private int velocidade;

    public void setVida(int vida)
    {
        this.vida = vida;
    }

    public int getVida()
    {
        return vida;
    }
    
    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return energia;
    }
    
    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}