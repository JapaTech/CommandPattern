using System.Collections.Generic;

//Invoker
public class RadioApp
{
    //Fila dos comandos
    public Stack<ICommand> commandCollection;

    public RadioApp()
    {
        commandCollection = new Stack<ICommand>();
    }

    //Adiciona comandos na fila e executa
    public void AddCommand(ICommand newCommand)
    {
        commandCollection.Push(newCommand);
        newCommand.Execute();
    }

    //Remove comandos na fila e retrocede a ação
    public void UndoCommand()
    {
        if(commandCollection.Count > 0)
        {
            ICommand lastestCommand = commandCollection.Pop();
            lastestCommand.Undo();
        }
    }
}