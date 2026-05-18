using UnityEngine;

public class ProyectilSpawner : MonoBehaviour
{
    public GameObject ProyectilEnemigo;
    public float spawnTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            Instantiate(ProyectilEnemigo, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
 
    }
}
