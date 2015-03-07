using UnityEngine;
using System.Collections;

public class brickCollision : MonoBehaviour {

    public GameObject panel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("dead");
            Destroy(gameObject);
            panel.SetActive(true);
        }
        else
        {
            Debug.Log("not dead yet");
            Destroy(gameObject);
        }

    }
}
