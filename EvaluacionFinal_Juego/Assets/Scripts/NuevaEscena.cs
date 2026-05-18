using UnityEngine;
using UnityEngine.SceneManagement;


public class NuevaEscena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemigo");

        if (enemigos.Length == 0)
        {
            int Victoria = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(Victoria + 2);
        }
    }
}
