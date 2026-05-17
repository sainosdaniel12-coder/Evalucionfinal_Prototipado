using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float Velocidad;
    public GameObject Explosion;
    private PuntosManager puntosManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntosManager = GameObject.Find("PuntosManager").GetComponent<PuntosManager>();
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
            puntosManager.UpdateScore(50);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
