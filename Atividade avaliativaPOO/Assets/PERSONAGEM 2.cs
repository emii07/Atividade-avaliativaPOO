using UnityEngine;

public class PERSONAGEM2 : MonoBehaviour
{
   
    [SerializeField] private string nome;
    [SerializeField] private int vida;
    [SerializeField] private int forcaDeAtaque;
    [SerializeField] private int defesa;

 
    public void AtribuirNome(string novoNome)
    {
        this.nome = novoNome;
    }

 
    public string ObterNome()
    {
        return this.nome;
    }

  
    public void AtribuirVida(int novaVida)
    {
        this.vida = novaVida;
    }

    
    public int ObterVida()
    {
        return this.vida;
    }


    public void AtribuirForcaDeAtaque(int novaForca)
    {
        this.forcaDeAtaque = novaForca;
    }

  
    public int ObterForcaDeAtaque()
    {
        return this.forcaDeAtaque;
    }

 
    public void AtribuirDefesa(int novaDefesa)
    {
        this.defesa = novaDefesa;
    }


    public int ObterDefesa()
    {
        return this.defesa;
    }
}
