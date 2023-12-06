using UnityEngine;

//Cliente
public class UserInput : MonoBehaviour
{
    //Ref�rencia do r�dio (reciver)
    public Radio radio;
    
    //Invoker
    private RadioApp radioApp;

    //Timer para impedir de trocar o som v�rias vezes seguidas
    private float cooldown;
    [SerializeField] private float delay;

    private void Start()
    {
        radioApp = new RadioApp();

        cooldown = delay;
    }

    private void Update()
    {
        cooldown -= Time.deltaTime;

        //Detect��o de inputs do teclado
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleRadio();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            NextMusic();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            PreviousMusic();
        }
    }

    //Solicita para avan�ar para a pr�xima m�sica
    public void NextMusic()
    {
        if(cooldown < 0)
        {
            ICommand radioChange = new NextSongCommand(radio);
            radioApp.AddCommand(radioChange);
            cooldown = delay;
        }
    }

    //Solicita para o invoker para voltar para a m�sica anterior
    public void PreviousMusic()
    {
        if(cooldown < 0 )
        {
            ICommand radioChange = new PreviousSongCommand(radio);
            radioApp.AddCommand(radioChange);
            cooldown = delay;
        }
    }

    //Solicita ao invoker para ligar ou desligar o r�dio
    public void ToggleRadio()
    {
        if(cooldown < 0)
        {
            ICommand radioToggle = new PlaySongCommand(radio);
            radioApp.AddCommand(radioToggle);
            cooldown = delay;
        }
    }

    //Desfaz o comando
    public void UndoCommand()
    {
        radioApp.UndoCommand();
    }
}
