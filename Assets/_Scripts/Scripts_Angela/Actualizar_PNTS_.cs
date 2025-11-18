using UnityEngine;

public class Actualizar_PNTS_ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="Meteorito"||collision.transform.tag=="Roca")
        {
            Game_Manager_.Instancia.ActualizarPuntuacion();
        }
    }
}
