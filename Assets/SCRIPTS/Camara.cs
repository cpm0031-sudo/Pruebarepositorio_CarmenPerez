using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject jugador;
    public Vector3 distanciaRelativa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + distanciaRelativa;
    }
}


