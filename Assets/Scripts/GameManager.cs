using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public float timer;
    public float timeToSpawn;
    public GameObject spawnObjects;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeToSpawn)
        {
            timer = 0;
            int randNum = Random.Range(0, spawnPoints.Length); // Corrected range
            GameObject newObject = Instantiate(spawnObjects, spawnPoints[randNum].transform.position, Quaternion.identity);

            // Attach the DestructionTimer script to the spawned object
            DestructionTimer destructionTimer = newObject.AddComponent<DestructionTimer>();
            destructionTimer.destroyAfterSeconds = 5.0f; // Adjust the time as needed
        }
    }
}

public class DestructionTimer : MonoBehaviour
{
    public float destroyAfterSeconds = 5.0f;

    private void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }
}
