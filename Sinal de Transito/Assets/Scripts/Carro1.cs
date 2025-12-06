using UnityEngine;

public class Carro1 : MonoBehaviour
{
    enum ESTADO3
    {
        PARADO,

        ANDANDO
    }
    
    [SerializeField]ESTADO3 estado3 = ESTADO3.ANDANDO;
    [SerializeField]int velocidade = 5;   
    void Update()
    {
        verificarcondi();
        if (transform.position.y > 1 && Semaforo.semaforo == Semaforo.ESTADO.AMARELO )
        {
            estado3 = ESTADO3.PARADO;
        }
        else
        {
            if(transform.position.y > 1 && Semaforo.semaforo == Semaforo.ESTADO.VERMELHO)
            {
                estado3 = ESTADO3.PARADO;
            }
            else
            {
                estado3 = ESTADO3.ANDANDO;
            }
        }
    }
    public void verificarcondi()
    {
        switch (estado3)
        {
            case ESTADO3.PARADO:

                break;
           case ESTADO3.ANDANDO:
                transform.position -= new Vector3(0, velocidade * Time.deltaTime,0);
                break;
        }
    }
}
