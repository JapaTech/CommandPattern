//Concret Command para tocar a m�sica anterior
public class PreviousSongCommand : ICommand
{
    //Reciver
    Radio radio;

    public PreviousSongCommand(Radio _radio)
    {
        radio = _radio;
    }

    //Executa o comando
    public void Execute()
    {
        radio.LastMusic();
    }

    //Desfaz o comando
    public void Undo()
    {
        radio.NextMusic();
    }
}
