using UnityEngine;
using System.Collections.Generic;

//Reciver
public class Radio : MonoBehaviour
{
    //Lista que guarda os clipes das m�sicas
    [SerializeField] private List<AudioClip> audioClips = new List<AudioClip>(); 

    //Verifica se o r�dio est� ligado ou desligado
    private bool isSongPlaying = false;
    
    //Indica qual � o n�mero na lista da m�sica tocando
    private int currentMusic = 0;

    private AudioSource audioToPlay;

    private void Start()
    {
        audioToPlay = GetComponent<AudioSource>();
        audioToPlay.clip = audioClips[currentMusic];
    }

    //Liga ou desliga o r�dio
    public void ToggleMusic()
    {
        //Se o r�dio estiver desligado, liga
        if (!isSongPlaying)
        {
            PlaySong();
        }
        //Caso contr�rio, desliga
        else
        {
            StopSong();
        }
    }

    //Muda a m�sica para a pr�xima da lista
    public void NextMusic()
    {
        if(currentMusic >= (audioClips.Count - 1) )
        {
            currentMusic = 0;
        }
        else
        {
            currentMusic++;
        }

        audioToPlay.clip = audioClips[currentMusic];

        if (isSongPlaying)
        {
            audioToPlay.Play();
        }
    }

    //Muda a m�sica para a �ltima que foi tocada
    public void LastMusic()
    {
        if (currentMusic == 0)
        {
            currentMusic = (audioClips.Count -1);
        }
        else
        {
            currentMusic--;
        }

        audioToPlay.clip = audioClips[currentMusic];

        if (isSongPlaying)
        {
            audioToPlay.Play();
        }
    }

    //Liga o r�dio
    private void PlaySong()
    {
        audioToPlay.Play();
        isSongPlaying = true;
    }

    //Desliga o r�dio
    private void StopSong()
    {
        audioToPlay.Stop();
        isSongPlaying = false;
    }
}
