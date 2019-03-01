using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {

    public GameObject rearCamera;
    float startTime; // declare this outside any function

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        // on right mouse click toggle the camera:
        if (Input.GetButtonDown("Fire2"))
        {
            // key pressed: save the current time
            startTime = Time.time;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            // key released: measure the time
            float timePressed = Time.time - startTime;
            // do here whatever you want with timePressed
            rearCamera.SetActive(false);
        }
        int RandNum = Random.Range(1, 1000);
        if (Input.GetButtonDown("Fire2"))
        {
            if (RandNum > 1)
            {
                if (RandNum < 1000)
                {
                    rearCamera.SetActive(true);
                }
            }
        }
    }
}
