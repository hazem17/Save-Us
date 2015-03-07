using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public Transform LeaderPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,LeaderPosition.position.y,Camera.main.transform.position.z);
	
    }
}
