using Unity.VisualScripting;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] Vector2 offset;
    [SerializeField] Vector2 velocidad;
    [SerializeField] Material material;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = velocidad * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
