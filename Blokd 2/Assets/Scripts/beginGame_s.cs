using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginGame_s : MonoBehaviour
{

    // public GameObject studioLogoObject;
    // public GameObject gameLogoObject;
    // public GameObject gameLogoSquareLeftObject;
    // public GameObject gameLogoSquareRightObject;
    
    // private float timeRemaining = 3.0f;
    // public bool timerIsRunning = false;


    // private Vector2 fingerDown;
    // private Vector2 fingerUp;
    // public bool detectSwipeOnlyAfterRelease = false;

    // public float SWIPE_THRESHOLD = 20f;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     Instantiate(studioLogoObject, transform.position, transform.rotation);
    //     timerIsRunning = true;
    // }


    // // Update is called once per frame
    // void Update()
    // {
    //     if (timerIsRunning)
    //     {
    //         if (timeRemaining > 0)
    //         {
    //             timeRemaining -= Time.deltaTime;
                
    //         } else
    //         {
    //             timeRemaining = 0;
    //             timerIsRunning = false;
        
    //             startGameLogo();
    //         }
    //     }

    //     Debug.Log("Test 1");


    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     }
    //       if (Input.GetMouseButtonUp(0))
    //     {
    //         endPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     }


    //     foreach (Touch touch in Input.touches)
    //     {
    //         Debug.Log("Test 2");

    //         if (touch.phase == TouchPhase.Began)
    //         {
    //             fingerUp = touch.position;
    //             fingerDown = touch.position;

    //             Debug.Log("Test 3");
    //         }

    //         //Detects Swipe while finger is still moving
    //         if (touch.phase == TouchPhase.Moved)
    //         {
    //             if (!detectSwipeOnlyAfterRelease)
    //             {
    //                 fingerDown = touch.position;
    //                 checkSwipe();
    //             }
    //         }

    //         //Detects swipe after finger is released
    //         if (touch.phase == TouchPhase.Ended)
    //         {
    //             fingerDown = touch.position;
    //             checkSwipe();
    //         }
    //     }



    // }

    // void startGameLogo ()
    // {


    //     //Debug.Log("startGameLogo fired");
    // }

    // void checkSwipe()
    // {
    //     //Check if Vertical swipe
    //     if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
    //     {
    //         //Debug.Log("Vertical");
    //         if (fingerDown.y - fingerUp.y > 0)//up swipe
    //         {
    //             OnSwipeUp();
    //         }
    //         else if (fingerDown.y - fingerUp.y < 0)//Down swipe
    //         {
    //             OnSwipeDown();
    //         }
    //         fingerUp = fingerDown;
    //     }

    //     //Check if Horizontal swipe
    //     else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
    //     {
    //         //Debug.Log("Horizontal");
    //         if (fingerDown.x - fingerUp.x > 0)//Right swipe
    //         {
    //             OnSwipeRight();
    //         }
    //         else if (fingerDown.x - fingerUp.x < 0)//Left swipe
    //         {
    //             OnSwipeLeft();
    //         }
    //         fingerUp = fingerDown;
    //     }

    //     //No Movement at-all
    //     else
    //     {
    //         //Debug.Log("No Swipe!");
    //     }
    // }

    // float verticalMove()
    // {
    //     return Mathf.Abs(fingerDown.y - fingerUp.y);
    // }

    // float horizontalValMove()
    // {
    //     return Mathf.Abs(fingerDown.x - fingerUp.x);
    // }

    // //////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
    // void OnSwipeUp()
    // {
    //     Debug.Log("Swipe UP");
    // }

    // void OnSwipeDown()
    // {
    //     Debug.Log("Swipe Down");
    // }

    // void OnSwipeLeft()
    // {
    //     Debug.Log("Swipe Left");
    // }

    // void OnSwipeRight()
    // {
    //     Debug.Log("Swipe Right");
    // }
}

    