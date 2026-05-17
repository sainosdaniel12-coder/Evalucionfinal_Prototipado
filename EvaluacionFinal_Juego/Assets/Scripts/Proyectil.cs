using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float Velocidad;
    public GameObject Explosion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemigo")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
