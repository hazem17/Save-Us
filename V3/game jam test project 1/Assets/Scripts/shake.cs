using UnityEngine;
using System.Collections;

public class shake : MonoBehaviour {


    float timer = 0.2f;
    float time = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
    bool rot = false;
	// Update is called once per frame
	void Update () {
        if (timer<=0 && rot == false)
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 1), 1);
            timer = time;
            rot = true;

        }
        else if (timer <= 0 && rot == true)
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 1), -1);
            timer = time;
            rot = false;
        }
        timer -= Time.deltaTime;
	}
}
