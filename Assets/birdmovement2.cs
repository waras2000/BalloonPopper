using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmovement2 : MonoBehaviour
{
    public Vector3 pointB;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        var pointA = transform.position;
        while(true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 1.0f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 1.0f));
        }
    }
   
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i= 0.0f;
        var rate= 0.5f/time;
        while(i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
