using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionParticlesPrefab;
    private Rigidbody bomba;
    float limitInf = 10.0f;
    float limitSup = 100.0f;

    // Use this for initialization
    void Start()
    {
        // Llama al método Inicio en lugar de definirlo dentro de Start
        Inicio();
    }

    // Método personalizado para la inicialización
    void Inicio()
    {
       

        float randomX = UnityEngine.Random.Range(10f, 100f);
        float randomY = UnityEngine.Random.Range(10f, 100f);
        float randomZ = UnityEngine.Random.Range(10f, 100f);

        Rigidbody bomba = GetComponent<Rigidbody>();
        bomba.AddTorque(randomX, randomY, randomZ);
    }

    // Este método se llama cuando se produce una colisión
    public void OnCollisionEnter(Collision collision)
    {
        if (explosionParticlesPrefab)
        {
            // Utiliza la notación moderna para la instanciación de objetos
            GameObject explosion = Instantiate(explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
            Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetimeMultiplier);
        }

        Destroy(gameObject);
    }
}
