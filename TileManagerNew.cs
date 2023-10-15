using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerNew : MonoBehaviour
{
    public GameObject[] field;
    public int zPos = 1;
    public bool creatingField = false;
    public int fieldNum;

    private void Update()
    {
        if(creatingField == false)
        {
            creatingField = true;
            StartCoroutine(GenerateField());
        }
    }

    IEnumerator GenerateField()
    {
        fieldNum = Random.Range(0, 8);
        Instantiate(field[fieldNum], new Vector3(-14.5f, -1.67f, zPos), Quaternion.identity);
        zPos += 1;
        yield return new WaitForSeconds(2);
        creatingField = false;



    }
}
