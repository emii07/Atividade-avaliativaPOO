using Unity.VisualScripting;
using UnityEngine;
// zumbi
public class PERSONAGEM
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int energia = 20;
    [ SerializeField ]
    private float imunidade;
    [ SerializeField ]
    private string habilidadeEspecial;
    [ SerializeField ]
    private int velocidade = 10;
    [ SerializeField ]
    private int força_de_ataque = 15;
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    public string Nome()
    {
        return this.nome; 
    }
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }
   
    public void AtribuirVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int Velocidade()
    {
        return this.velocidade;
    }
    
    public void AtribuirForca_Ataque(int forca_ataque)
    
    {
            this.força_de_ataque = forca_ataque;
    }
    public int Forca_Ataque()
    {
        return this.força_de_ataque;
    }

    public void atribuirHabilidadeEspecial(string habilidadeEspecial)
    {
        this.habilidadeEspecial = habilidadeEspecial;
    }

    public string HabilidadeEspecial()
    {
        return this.habilidadeEspecial;
    }
}
