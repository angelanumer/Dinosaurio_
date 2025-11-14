using TMPro;
using UnityEngine;

public class Game_Manager_ : MonoBehaviour
{
    public static Game_Manager_ Instancia;
    [SerializeField] int puntuacionActual;
    [SerializeField] int puntuacionMaxima;
    [SerializeField] float tiempo;

    [SerializeField] TMP_Text actual;
    [SerializeField] TMP_Text maxima;
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
        puntuacionMaxima = PlayerPrefs.GetInt("PUNTUACION");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Perder()
    { 
        
    }


    private void ReiniciarJuego()
    { 
        
    }

    private void ActualizarPuntuacion()
    {
        puntuacionActual++;
        if(puntuacionActual>puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("PUNTUACION", puntuacionMaxima);
        }
    }
}
