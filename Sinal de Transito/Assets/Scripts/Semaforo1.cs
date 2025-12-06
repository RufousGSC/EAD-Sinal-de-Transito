using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Semaforo : MonoBehaviour
{

    public enum ESTADO
    {
        VERMELHO,
        AMARELO,
        VERDE
    }
    [SerializeField] public static ESTADO semaforo = ESTADO.VERMELHO;
    [SerializeField] float tempo = 0.0f;
    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo < 1f)
        {
            semaforo = ESTADO.VERDE;
        }
        if (tempo > 1f && tempo < 2f)
        {
            semaforo = ESTADO.AMARELO;
        }
        if (tempo > 2f && tempo < 3f)
        {
            semaforo = ESTADO.VERMELHO;
        }
        if(tempo > 4f)
        {
            tempo = 0.0f;
        }
        acoessemaforo();
    }
    public void acoessemaforo()
    {
        switch (semaforo)
        {
            case ESTADO.VERMELHO:
                GetComponent<Renderer>().material.color = Color.red;

                break;
            case ESTADO.AMARELO:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case ESTADO.VERDE:
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}
