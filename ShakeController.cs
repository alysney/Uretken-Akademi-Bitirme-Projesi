using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeController : MonoBehaviour
{
    public float duration = 1f;
    public AnimationCurve curve;

    private bool isShaking = false;
    private void Update()
    {
        if (isShaking)
        {
            isShaking = false; 
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime/duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            // startPosition = transform.position;
            yield return null;
        }

        transform.position = startPosition;



    }
    public void StartShake() 
    {
        isShaking = true;
    }
}
