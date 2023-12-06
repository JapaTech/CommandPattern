using UnityEngine;

//O cliente que pede para o comando ser executado
public class Tabuleiro : MonoBehaviour
{
    //Referência da peça do tabuleiro (reciver)
    [SerializeField] private Peca peca;
    
    //Direções que a peça pode se mover
    private Direcao direcaoEsq;
    private Direcao direcaoDir;
    private Direcao direcaoCima;
    private Direcao direcaoBaixo;

    //Invoker
    private MoverPecas moverPecas;

    private void Start()
    {
        moverPecas = new MoverPecas();

        //Cria a direção que a peça pode mover
        direcaoEsq = new Direcao(Direcoes.esquerda);
        direcaoDir = new Direcao(Direcoes.direita);
        direcaoCima = new Direcao(Direcoes.cima);
        direcaoBaixo = new Direcao(Direcoes.baixo);
    }

    //Move a peça no tabuleiro
    public void Mover(int i)
    {
        //Cria uma direção a partir do paramêtro passado pelo botão
        Direcoes direcao = (Direcoes) i;
        
        //Cria o comando para mover
        ICommand mover;

        //'Pergunta' para a peca pode se ela pode se mover para aquela direção
        bool podeMover = peca.VerificaSePodeMover(direcao);
        
        //Se não poder sai da função e não executa o comando
        if (!podeMover)
            return;

        //Cria o comando para se mover de acordo com a direção passada
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
                //Aponta que foi passado uma direção errada
                throw new System.NullReferenceException("Verifique se o paramêtro do botão está entre 0 e 3");
        }
        
        //Envia o comando para o invoker para ser executado
        moverPecas.AdcComando(mover);

    }

    //Pede para o invoker o desfazer o último comando.
    public void DesfazerComando()
    {
        moverPecas.DesfazerComando();
    }
}
