using TMPro;
using UnityEngine;

public class Textos_ : MonoBehaviour
{
    [SerializeField] TMP_Text pActual;
    [SerializeField] TMP_Text pMax;
    [SerializeField] TMP_Text tiempo;

    [SerializeField] int minutos;
    [SerializeField] int segundos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pActual.text=Game_Manager_.Instancia.puntuacionActual.ToString("D3");
        pMax.text = Game_Manager_.Instancia.puntuacionMaxima.ToString("D3");
        minutos = (int)Game_Manager_.Instancia.tiempo / 60;
        segundos = (int)Game_Manager_.Instancia.tiempo % 60;

        tiempo.text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
    }

    // Update is called once per frame
    void Update()
    {
        pActual.text = Game_Manager_.Instancia.puntuacionActual.ToString("D3");
        pMax.text = Game_Manager_.Instancia.puntuacionMaxima.ToString("D3");
        minutos = (int)Game_Manager_.Instancia.tiempo / 60;
        segundos = (int)Game_Manager_.Instancia.tiempo % 60;

        tiempo.text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
    }
}
