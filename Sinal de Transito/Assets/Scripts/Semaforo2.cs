using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using static Semaforo;

public class Semaforo2 : MonoBehaviour
{
    public enum ESTADO2
    {
        VERMELHO,
        AMARELO,
        VERDE
    }
    [SerializeField] public static ESTADO2 semaforo2 = ESTADO2.VERMELHO;
    [SerializeField] float tempo2 = 0.0f;
    void Update()
    {
        tempo2 += Time.deltaTime;
        if (tempo2 < 2f)
        {
            semaforo2 = ESTADO2.VERMELHO;
        }
        if (tempo2 > 2f && tempo2 < 3f)
        {
            semaforo2 = ESTADO2.VERDE;
        }
        if (tempo2 > 3f && tempo2 < 4f)
        {
            semaforo2 = ESTADO2.AMARELO;
        }
        if (tempo2 > 4f)
        {
            tempo2 = 0.0f;
        }
        acoessemaforo2();
    }
    public void acoessemaforo2()
    {
        switch (semaforo2)
        {
            case ESTADO2.VERMELHO:
                GetComponent<Renderer>().material.color = Color.red;

                break;
            case ESTADO2.AMARELO:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case ESTADO2.VERDE:
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}