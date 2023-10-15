using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float _spawn = 0;
    public float tileLength = 1;
    public int numberofTiles = 7;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;

    void Start()
    {
        for (int i = 0; i < numberofTiles; i++)
        {
            if (i == 0)
            {
                Spawntile(0);
            }
            else
            {
                Spawntile(Random.Range(0, tilePrefabs.Length));
            }
        }
    }

    void Update()
    {
        if (playerTransform.position.z - 0.5 > _spawn - (numberofTiles * tileLength))
        {
            Spawntile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    public void Spawntile(int tileIndex)
    {
        
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * _spawn, transform.rotation);
        activeTiles.Add(go);
        _spawn += tileLength;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
