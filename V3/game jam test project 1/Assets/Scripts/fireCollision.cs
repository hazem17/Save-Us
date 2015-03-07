using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class fireCollision : MonoBehaviour {

	// Use this for initialization
    float time = 4.0f;
    //public ParticleSystem onFire;
    public GameObject catchOnFire;
    public GameObject onFire;
    public AudioClip onFireSound;
    public AudioSource audioSource;
    public GameObject panel;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (time>=2)
        {
            gameObject.particleSystem.startLifetime = 3;
        }
        else if(time>=0)
        {
            gameObject.particleSystem.startLifetime = 0;
            
        }
        else
        {
            time = 4.0f;
        }
        time -= Time.deltaTime;
        
	}

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("here!!!!");
        if (other.tag == "Player")
        {
            if (other.GetComponent<hasFire>().fire == false)
            {
                GameObject childObject = Instantiate(catchOnFire) as GameObject;
                //Instantiate(catchOnFire);
                childObject.transform.parent = other.gameObject.transform;
                childObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0);
                other.GetComponent<hasFire>().fire = true;


                audio.loop = true;
                audio.Play();
                panel.gameObject.SetActive(true);
                //AudioSource.PlayClipAtPoint(onFireSound, Camera.main.transform.position);
                //gameObject.audio.loop = true;
            }
            
        }
    }
}
