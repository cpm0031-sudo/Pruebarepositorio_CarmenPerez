using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 3f;

    private Transform objetivoActual;
    void Start()
    {
        objetivoActual = puntoA;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivoActual.position, velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position, objetivoActual.position) < 0.2f)
        {
            objetivoActual = (objetivoActual == puntoA) ? puntoB : puntoA;
        }
    }
}
