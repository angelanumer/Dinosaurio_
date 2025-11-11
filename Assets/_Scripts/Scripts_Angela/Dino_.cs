using UnityEngine;
using UnityEngine.InputSystem;

public class Dino_ : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float alturaSalto;

    [SerializeField] Animator animacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Saltar(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            animacion.SetBool("Salto_", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animacion.SetBool("Salto_", false);
    }
}
