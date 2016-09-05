using UnityEngine;
using System.Collections;

public class LerpTest : MonoBehaviour {

    float lerpTime = 2.4f;
    float currentLerpTime;
 
    float moveDistance = 10f;
 
    Vector3 startPos;
    Vector3 endPos;
 
    protected void Start() {
        startPos = transform.position;
        endPos = transform.position + transform.up * moveDistance;
    }
 
    protected void Update() {
        //reset when we press spacebar
        if (Input.GetKeyDown(KeyCode.Space)) {
            currentLerpTime = 0f;
        }
 
        //increment timer once per frame
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime) {
            currentLerpTime = lerpTime;
        }
 
        //lerp!
        float t = currentLerpTime / lerpTime;
        t = t*t;
        transform.position = Vector3.Lerp(startPos, endPos, t);
    }
}

/* Add'l lerp lines and curves

float t = currentLerpTime / lerpTime;
t = Mathf.Sin(t * Mathf.PI * 0.5f);

t = 1f - Mathf.Cos(t * Mathf.PI * 0.5f);

t = t*t;

t = t*t * (3f - 2f*t);

t = t*t*t * (t * (6f*t - 15f) + 10f);

*/