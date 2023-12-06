using UnityEngine;

//Reciver (quem recebe o comando)
public class Peca : MonoBehaviour
{
    [Header("Limita movimentação na direita e em cima")]
    [SerializeField] private Vector2 limiteMovMaxima;

    [Header("Limita movimentação na esquerda e em baixo")]
    [SerializeField] private Vector2 limiteMovMinima;

    private RectTransform rect;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    //Move a peça mudando o valor rectTransform
    public void MoverPara(Direcoes dir)
    {
        switch (dir)
        {
            case Direcoes.esquerda:
                Debug.Log(dir);
                rect.anchoredPosition += Vector2.left * 162;
                break;
            case Direcoes.direita:
                Debug.Log(dir);
                rect.anchoredPosition += Vector2.right * 162;
                break;
            case Direcoes.cima:
                Debug.Log(dir);
                rect.anchoredPosition += Vector2.up * 162;
                break;
            case Direcoes.baixo:
                Debug.Log(dir);
                rect.anchoredPosition += Vector2.down * 162;
                break;
            default:
                throw new System.NullReferenceException("Direção inválida");
        }
    }

    //Verifica se a peça pode mover para a direção
    public bool VerificaSePodeMover(Direcoes direcoes) 
    {
        bool podeMover = true;
        switch (direcoes)
        {
            case Direcoes.esquerda:
                if(rect.anchoredPosition.x <= limiteMovMinima.x)
                    podeMover = false;
                break;
            case Direcoes.direita:
                if (rect.anchoredPosition.x >= limiteMovMaxima.x)
                    podeMover = false;
                break;
            case Direcoes.cima:
                if (rect.anchoredPosition.y >= limiteMovMaxima.y)
                    podeMover = false;
                break;
            case Direcoes.baixo:
                if (rect.anchoredPosition.y <= limiteMovMinima.y)
                    podeMover = false;
                break;
            default:
                throw new System.NullReferenceException("Posição inválida");
        }
        return podeMover;
    }
}
