using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

    public GameObject panel2;
    public int counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (counter>=3)
        {
            Debug.Log("win");
            panel2.gameObject.SetActive(true);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("ddd");
        if (col.gameObject.tag == "Player")
        {
            counter++;
        }
    }
}
