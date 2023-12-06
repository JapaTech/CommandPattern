using UnityEngine;
using System.Collections.Generic;

//Reciver
public class Radio : MonoBehaviour
{
    //Lista que guarda os clipes das músicas
    [SerializeField] private List<AudioClip> audioClips = new List<AudioClip>(); 

    //Verifica se o rádio está ligado ou desligado
    private bool isSongPlaying = false;
    
    //Indica qual é o número na lista da música tocando
    private int currentMusic = 0;

    private AudioSource audioToPlay;

    private void Start()
    {
        audioToPlay = GetComponent<AudioSource>();
        audioToPlay.clip = audioClips[currentMusic];
    }

    //Liga ou desliga o rádio
    public void ToggleMusic()
    {
        //Se o rádio estiver desligado, liga
        if (!isSongPlaying)
        {
            PlaySong();
        }
        //Caso contrário, desliga
        else
        {
            StopSong();
        }
    }

    //Muda a música para a próxima da lista
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

    //Muda a música para a última que foi tocada
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

    //Liga o rádio
    private void PlaySong()
    {
        audioToPlay.Play();
        isSongPlaying = true;
    }

    //Desliga o rádio
    private void StopSong()
    {
        audioToPlay.Stop();
        isSongPlaying = false;
    }
}
