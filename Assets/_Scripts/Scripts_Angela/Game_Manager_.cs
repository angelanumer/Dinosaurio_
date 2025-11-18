using TMPro;
using UnityEngine;

public class Game_Manager_ : MonoBehaviour
{
    public static Game_Manager_ Instancia;
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] public float tiempo;

    [SerializeField] TMP_Text actual;
    [SerializeField] TMP_Text maxima;

    [SerializeField] GameObject marca;

    [SerializeField] GameObject imagenperder;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool cronometro;
    [SerializeField] meteorito enemigoscript;
    [SerializeField] int PuntuacionActual;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imagenperder.SetActive(false);
        boton.SetActive(false);
        puntuacionMaxima = PlayerPrefs.GetInt("PUNTUACION");
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometro == true)
        {
            tiempo = Time.deltaTime + tiempo;
        }
    }

    public void ActualizarPuntuacion()
    {
        puntuacionActual++;
        if(puntuacionActual>puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("PUNTUACION", puntuacionMaxima);
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
        PuntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        boton.SetActive(false);
        imagenperder.SetActive(false);
        tiempo = 0;
        cronometro = true;
        enemigoscript.ReiniciarEnemigo();

    }
}
