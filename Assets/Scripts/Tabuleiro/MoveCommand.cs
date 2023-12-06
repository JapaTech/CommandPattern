//O concrete command que move a pe�a
public class MoveCommand : ICommand
{
    //Ref�ncia da pe�a
    private Peca peca;

    //Dire��o que ir� se mover
    private Direcao direcao;

    //Construtor
    public MoveCommand(Peca _peca, Direcao _direcao)
    {
        peca = _peca;
        direcao = _direcao;
    }

    //Executa o comando
    public void Execute()
    {
        peca.MoverPara(direcao.ReturnDirecao());
    }

    //Desfaz o comando
    public void Undo()
    {
        peca.MoverPara(direcao.ReturnDirecaoOposta());
    }
}
