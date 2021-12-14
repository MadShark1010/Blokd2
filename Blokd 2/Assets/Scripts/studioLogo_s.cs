using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studioLogo_s : MonoBehaviour
{
    private float timeRemaining = 1.0f;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        // Debug.Log("Time = " + timeRemaining);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                // Debug.Log("Time = " + timeRemaining);
                // Debug.Log("Delta = " + Time.deltaTime);
            } else
            {
                timeRemaining = 0;
                timerIsRunning = false;
        
                StartCoroutine(FadeTo(0.0f, 1.0f));
            }
        }
    }

    IEnumerator FadeTo(float aValue, float aTime)
     {
         float alpha = transform.GetComponent<SpriteRenderer>().material.color.a;
         for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
         {
          Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,aValue,t));
             transform.GetComponent<SpriteRenderer>().material.color = newColor;
             yield return null;
         }
     }
}
