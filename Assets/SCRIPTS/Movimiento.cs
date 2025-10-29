using UnityEngine;
using TMPro;

public class Movimiento : MonoBehaviour
{
    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI mensajeFinal;

    public int contador = 0;


    public int vida = 10;
    public float daño = 20f;
    public bool salto = false; //En falso para que no salte hasta que sea verdadero
    public string personajeDice = "Hola como estas";
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    public Rigidbody  rb;
    public bool ensuelo = true;
    public float sensibilidadRaton = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("El Juego Empieza");
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");

        transform.Rotate(0, moveX * sensibilidadRaton, 0); 

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("El Personaje Se Mueve");
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space) & ensuelo == true)
        {
           rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }

        if(contador == 10)
        {
            mensajeFinal.text = "Game Over";
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            ensuelo = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            ensuelo = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("item"))
        {

            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("item"))
        {
            Destroy(other.gameObject);

            contador++;

            textoContador.text = "Puntos: " + contador;
        }
    }
}