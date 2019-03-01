using System.Collections;
using System.Collections.Generic;
using CompleteProject;
using UnityEngine;

public class AppleCollection : MonoBehaviour {
    public int scoreValue = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //ScoreManager.score += scoreValue;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            ScoreManager.score += scoreValue;
            Destroy(gameObject, 2f);
        }
    }
}
