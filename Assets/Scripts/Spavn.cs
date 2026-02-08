using UnityEngine;
using UnityEngine.SceneManagement;

public class Spavn : MonoBehaviour
{
    public GameObject obj;
    private float randomX;
    Vector2 whereToSpawn;
    public float spawnDelay = 3f;
    float nextSpawn = 3f;

    public float defaultSpawnTime = 4f;
    private float spawnTime = 4f;
    private float realTime = 4f;

    private void Start()
    {
        
    }

    

    private void Update()
    {
        spawnTime -= Time.deltaTime;
        realTime += Time.deltaTime;

        if (spawnTime < 0 && realTime < 30f && realTime > 5f)
        {
           
            GameObject Enemy = Instantiate(obj, transform.position, Quaternion.identity);
           
            Destroy(Enemy, 1.7f);

            spawnTime = defaultSpawnTime;
        }

        if (realTime > 30f)
        {
            realTime = 0f;
        }

        
       
    }
}
