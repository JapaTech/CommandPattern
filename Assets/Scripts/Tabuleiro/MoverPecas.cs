using System.Collections.Generic;

//Invoker
public class MoverPecas 
{
    //Fila de comandos
    public Stack<ICommand> commandCollection;

    public MoverPecas()
    {
        commandCollection = new Stack<ICommand>();
    }

    //Adiciona um comando na lista e o executa
    public void AdcComando(ICommand novoComando)
    {
        commandCollection.Push(novoComando);
        novoComando.Execute();
    }

    //Retira o comando da fila e executa a operação inversa
    public void DesfazerComando()
    {
        if(commandCollection.Count > 0)
        {
            ICommand ultimoComando = commandCollection.Pop();
            ultimoComando.Undo();
        }

    }
}
