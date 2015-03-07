using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManageTimeLeft : MonoBehaviour {

   
    public float timer;
    public Text mytext;
 
	// Use this for initialization
	void Start () {
        timer = 60;
        GameObject canvas = GameObject.Find("Canvas");
        mytext = canvas.GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        mytext.text = "Time Left: " + timer;
	}
}
