
using UnityEngine;

public class meteorito : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera Camara;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] Vector2 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camara = Camera.main;
        posicionMinima = Camara.ViewportToWorldPoint(Vector2.zero);
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform .position = posicionInicial;
            velocidad = velocidad + 0.5f;
        }
    }


}
