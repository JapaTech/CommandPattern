//Jeito antigo, command incompleta, pode ignorar
public class RadioSwitch
{
    ICommand onCommand;

    public RadioSwitch(ICommand command)
    {
        onCommand = command;
    }

    public void Toggle()
    {
        onCommand.Execute();
    }
}
