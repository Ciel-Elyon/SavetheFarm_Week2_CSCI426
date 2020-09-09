using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject[] resourcePrefabs;

    [SerializeField]
    public Transform[] spawnPoints;

    [SerializeField]
    public float minDelay = .1f;
    [SerializeField]
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnResources());
    }

    IEnumerator SpawnResources()
    {
        while (!GameCode.instance.cropeaten && !GameCode.instance.sheepeaten)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            int spawnType = Random.Range(0, resourcePrefabs.Length);

            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject resourceSpawned = Instantiate(resourcePrefabs[spawnType], spawnPoint.position, spawnPoint.rotation);

            Destroy(resourceSpawned, 2f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
