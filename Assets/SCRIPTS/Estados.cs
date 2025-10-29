using UnityEngine;

public class Estados : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }


    void Update()
    {
        anim.SetBool("Caminata", false);
        anim.SetBool("Parado", true);
        anim.SetBool("Salto", false);

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Caminata", true);
            anim.SetBool("Parado", false);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Caminata", true);
            anim.SetBool("Parado", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Caminata", true);
            anim.SetBool("Parado", false);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Caminata", true);
            anim.SetBool("Parado", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Salto", true);
            anim.SetBool("Caminata", false);
            anim.SetBool("Parado", false);
        }
    }
}
