using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject platformBigPrefab;
    public GameObject platformFall;

    public int numberOfPlatforms=500;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 3.0f;
    // Use this for initialization
    void Start () {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            if (i % 6 == 0)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformBigPrefab, spawnPosition, Quaternion.identity);
            }

            if(i % 3 == 0)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformFall, spawnPosition, Quaternion.identity);
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
