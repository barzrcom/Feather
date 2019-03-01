using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour {

    public GameObject replacement;

    private void OnCollisionEnter(Collision collision)
    {
        Action();
    }

    public void Action()
    {
        GameObject.Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
