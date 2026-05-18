using UnityEngine;
using UnityEngine.SceneManagement;

public class ConttrolEnemigos : MonoBehaviour
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
            int Nivel_2 = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(Nivel_2 + 1);
        }
    }
}
