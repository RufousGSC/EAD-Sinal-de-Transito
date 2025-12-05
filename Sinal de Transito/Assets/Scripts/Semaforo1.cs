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

    [SerializeField] public ESTADO semaforo = ESTADO.VERMELHO;
    [SerializeField] float tempo = 0.0f;   
   
    void Start()
    {
        
    }

    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo < 5f)
        {
            semaforo = ESTADO.VERDE;
        }
        if (tempo > 5f && tempo < 8f)
        {
            semaforo = ESTADO.AMARELO;
        }
        if (tempo > 8f && tempo < 16f)
        {
            semaforo = ESTADO.VERMELHO;
        }
        if(tempo > 16f)
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
