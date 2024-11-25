using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    int contador = 10;
    public GameObject itemFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Salir del juego
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            contador -= 1;
            if (contador == 0)
            {
                itemFinal.SetActive(true);
            }
        }

        if (other.gameObject.tag == "Finish")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
