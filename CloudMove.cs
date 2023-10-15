using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 0.4f;
    private Vector3 dir = Vector3.right;

    void Update()
    {

        transform.Translate(dir * speed * Time.deltaTime);
    }

}
