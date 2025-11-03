using UnityEngine;

public class Jogador : Personagem
{
    public float velocidadeRotacao = 300f;
    public Quaternion targetRotacao;
    void Start()
    {
        targetRotacao = transform.rotation;
    }

   
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(getVelocidade()* Time.deltaTime, 0, 0);
            targetRotacao = Quaternion.Euler(0, 0, 90);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade()* Time.deltaTime, 0, 0);
            targetRotacao = Quaternion.Euler(0, 0, 90);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade()* Time.deltaTime, 0);
            targetRotacao = Quaternion.Euler(0, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade()* Time.deltaTime, 0);
            targetRotacao = Quaternion.Euler(0, 0, 0);
        }
        
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotacao, velocidadeRotacao * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            int vidas = getVida() - 1;
            setVida(vidas);
        }
         
    }
}
