using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Velocidad = 5;
    public float hInput;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        
        transform.Translate(Vector2.right * hInput *Velocidad * Time.deltaTime);
    }
}
