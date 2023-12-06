//Concrete Commamnd para ligar/desligar o radio
public class PlaySongCommand : ICommand
{
    //Reciver
    private Radio radio;

    public PlaySongCommand(Radio _radio)
    {
        radio = _radio;
    }

    //Executa o comando
    public void Execute()
    {
        radio.ToggleMusic();
    }

    //Desfaz o comando
    public void Undo() 
    {
        radio.ToggleMusic();
    }
  
}
