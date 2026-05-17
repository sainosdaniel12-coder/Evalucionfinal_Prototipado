using UnityEngine;
using UnityEngine.UI;

public class VidasJugador : MonoBehaviour
{
    public int Vidas = 3;
    public Image[] VidasUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemigo")
        {
            Destroy(collision.collider.gameObject);
            Vidas -= 1;
            for(int i = 0; i < VidasUI.Length; i++)
            {
                if(i < Vidas)
                {
                    VidasUI[i].enabled = true;
                }
                else
                {
                    VidasUI[i].enabled = false;
                }
            } 
            if (Vidas <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
