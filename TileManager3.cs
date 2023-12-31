using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager3 : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float SpawnZ = 0.0f;
    //yarim yapabilirsin
    private float tileLength = 45.9f;
    private int amnTilesOnScreen = 7;
    private float safeZone = 40;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;
    void Start()
    {
        activeTiles = new List<GameObject>(); 
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
     if(playerTransform.position.z - safeZone> (SpawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }   
    }

    private void SpawnTile(int prefabIndex = -1)

    {
        GameObject go;
        go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(-15, 0, SpawnZ); 
        SpawnZ += tileLength;
        activeTiles.Add(go);    

    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
            return 0;
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0,tilePrefabs.Length); 
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
