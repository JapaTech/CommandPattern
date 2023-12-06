//Concrete Commamnd para avan�ar para a pr�xima m�sica
public class NextSongCommand : ICommand
{
    //Reciver
    Radio radio;

    public NextSongCommand(Radio _radio)
    {
        radio = _radio;
    }

    //Executar o comando
    public void Execute()
    {
        radio.NextMusic();
    }

    //Desfazer o comanodo
    public void Undo()
    {
        radio.LastMusic();
    }
}
