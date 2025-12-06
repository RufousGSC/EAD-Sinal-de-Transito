using UnityEngine;
using static Semaforo;

public class Carro2 : MonoBehaviour
{
    enum ESTADO4
    {
        PARADO,

        ANDANDO
    }
    [SerializeField] ESTADO4 estado4 = ESTADO4.ANDANDO;
    [SerializeField] int velocidade = 5;
    void Update()
    {
        verificarcondi2();
        if (transform.position.x > 2 && Semaforo2.semaforo2 == Semaforo2.ESTADO2.AMARELO)
        {
            estado4 = ESTADO4.PARADO;
        }
        else
        {
            if (transform.position.x > 2 && Semaforo2.semaforo2 == Semaforo2.ESTADO2.VERMELHO)
            {
                estado4 = ESTADO4.PARADO;
            }
            else
            {
                estado4 = ESTADO4.ANDANDO;
            }
        }
    }
    public void verificarcondi2()
    {
        switch (estado4)
        {
            case ESTADO4.PARADO:

                break;
            case ESTADO4.ANDANDO:
                transform.position -= new Vector3(velocidade * Time.deltaTime, 0, 0);
                break;
        }
    }
}
