using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public int score;
    public TMP_Text puntosTexto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void UpdateScore(int points)
    {
        score += points;
        puntosTexto.text = "Puntos: " + score;
    }
    
}
