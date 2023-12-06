using UnityEngine;

//O cliente que pede para o comando ser executado
public class Tabuleiro : MonoBehaviour
{
    //Refer�ncia da pe�a do tabuleiro (reciver)
    [SerializeField] private Peca peca;
    
    //Dire��es que a pe�a pode se mover
    private Direcao direcaoEsq;
    private Direcao direcaoDir;
    private Direcao direcaoCima;
    private Direcao direcaoBaixo;

    //Invoker
    private MoverPecas moverPecas;

    private void Start()
    {
        moverPecas = new MoverPecas();

        //Cria a dire��o que a pe�a pode mover
        direcaoEsq = new Direcao(Direcoes.esquerda);
        direcaoDir = new Direcao(Direcoes.direita);
        direcaoCima = new Direcao(Direcoes.cima);
        direcaoBaixo = new Direcao(Direcoes.baixo);
    }

    //Move a pe�a no tabuleiro
    public void Mover(int i)
    {
        //Cria uma dire��o a partir do param�tro passado pelo bot�o
        Direcoes direcao = (Direcoes) i;
        
        //Cria o comando para mover
        ICommand mover;

        //'Pergunta' para a peca pode se ela pode se mover para aquela dire��o
        bool podeMover = peca.VerificaSePodeMover(direcao);
        
        //Se n�o poder sai da fun��o e n�o executa o comando
        if (!podeMover)
            return;

        //Cria o comando para se mover de acordo com a dire��o passada
        switch (direcao)
        {
            case Direcoes.esquerda:
                mover = new MoveCommand(peca, direcaoEsq);
                break;
            case Direcoes.direita:
                 mover = new MoveCommand(peca, direcaoDir);
                break;
            case Direcoes.cima:
                mover = new MoveCommand(peca, direcaoCima);
                break;
            case Direcoes.baixo:
                mover = new MoveCommand(peca, direcaoBaixo);
                break;
            default:
                //Aponta que foi passado uma dire��o errada
                throw new System.NullReferenceException("Verifique se o param�tro do bot�o est� entre 0 e 3");
        }
        
        //Envia o comando para o invoker para ser executado
        moverPecas.AdcComando(mover);

    }

    //Pede para o invoker o desfazer o �ltimo comando.
    public void DesfazerComando()
    {
        moverPecas.DesfazerComando();
    }
}
