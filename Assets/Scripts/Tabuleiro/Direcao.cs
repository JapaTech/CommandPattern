using System.Collections.Generic;

//As dire��es poss�veis para se mover
public enum Direcoes
{
    esquerda,
    direita,
    cima,
    baixo
}

public class Direcao
{
    private Direcoes dir;

    //Construtor
    public Direcao(Direcoes _dir)
    {
        dir = _dir;
    }

    //Retorna a dire��o armazenada
    public Direcoes ReturnDirecao()
    { 
        return dir;
    }

    //Retorna a dire��o oposta da armazenada
    public Direcoes ReturnDirecaoOposta() => dir switch
    {
        Direcoes.esquerda => Direcoes.direita,
        Direcoes.direita => Direcoes.esquerda,
        Direcoes.cima => Direcoes.baixo,
        Direcoes.baixo => Direcoes.cima,
        _ => throw new KeyNotFoundException(nameof(dir))
    };
}
