using System.Collections;
using UnityEngine;

public class GAmeManager : MonoBehaviour
{
    public static GAmeManager Instancia;
    [SerializeField] GameObject imagenperder;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool cronometro;
    [SerializeField] meteorito enemigoscript;
    [SerializeField] int PuntuacionActual;
    [SerializeField] float tiempo;
    void Start()
    {
        imagenperder.SetActive(false);
        boton.SetActive(false);
    }

    void Update()
    {
        if (cronometro == true) 
        {
            tiempo = Time.deltaTime + tiempo;
        }
    }
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
       
            jugador.SetActive(false);
            enemigo.SetActive(false);
            imagenperder.SetActive(true);
            boton.SetActive(true);
            cronometro = false;
        
    }
    public void Reiniciarjuego()
    { 
        PuntuacionActual= 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        tiempo = 0;
        cronometro = true;

    }
    
}
