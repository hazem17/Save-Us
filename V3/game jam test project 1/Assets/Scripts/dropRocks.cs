using UnityEngine;
using System.Collections;

public class dropRocks : MonoBehaviour {

    public GameObject brick;
    float timer = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Instantiate(brick);
            brick.transform.position = new Vector2(0, 0);
            timer = 3.0f;

        }

	}
}
