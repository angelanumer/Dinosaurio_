using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Seixas_");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
