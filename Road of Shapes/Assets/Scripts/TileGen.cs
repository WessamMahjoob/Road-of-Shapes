using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGen : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles = 3;
    private List<GameObject> activeTiles = new List<GameObject>();

    public Transform playerTransform;
    void Start()
    {
        for (int i = 0; i < numberOfTiles-4; i++)
        {
            
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }

    }
    void Update()
    {
        if (playerTransform != null) { 

          if (playerTransform.position.z - 400 > zSpawn - (numberOfTiles * tileLength))
          {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
          }
        }
    }
    public void SpawnTile(int tileIndex)
    {

        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
