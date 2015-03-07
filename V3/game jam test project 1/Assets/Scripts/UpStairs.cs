using UnityEngine;
using System.Collections;

public class UpStairs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public AudioClip a;
	
	// Update is called once per frame
	void Update () {
	

	}

    void OnTriggerEnter2D(Collider2D other)

    {
        other.rigidbody2D.drag = 3;
        AudioSource.PlayClipAtPoint(a, Camera.main.transform.position);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        other.rigidbody2D.drag = 0;
        AudioSource.PlayClipAtPoint(a, Camera.main.transform.position);
    
    }


}
