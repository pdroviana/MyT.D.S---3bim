using System;
using UnityEditor;
using UnityEngine;

public class Dano : MonoBehaviour
{

    [SerializeField] private int dano;
    [SerializeField] private float velocidade;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
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
        transform.position += transform.right * velocidade * Time.deltaTime;
        
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            int novaVida = other.gameObject.GetComponent<Personagem>().getVida() - getDano();
            other.gameObject.GetComponent<Personagem>().setVida(novaVida);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(gameObject);
        }
            
        
        
    }

    
    
}
