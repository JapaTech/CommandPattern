//O concrete command que move a peça
public class MoveCommand : ICommand
{
    //Refência da peça
    private Peca peca;

    //Direção que irá se mover
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
