using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour
{

    public float speed = 8;
    float OldPosition;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = Vector3.zero;
        //dir.z = -Input.acceleration.y;
        dir.x = Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);


        
       
        if (gameObject.transform.position.x > OldPosition )//Right
        {
            gameObject.transform.localScale = new Vector3(-0.5f,0.5f,0.2f);
            OldPosition = gameObject.transform.position.x;
            Debug.Log("IF");
        }
        else//Left
        {
            gameObject.transform.localScale = new Vector3(0.5f,0.5f,0.2f);
            Debug.Log("ELSE");

        }
        OldPosition = gameObject.transform.position.x;

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        //int i = 0;
        //while (i < Input.touchCount)
        //{
        //    if (Input.GetTouch(i).phase == TouchPhase.Began)
        //    {
        //        gameObject.rigidbody2D.AddForce(new Vector3(0, 15), ForceMode2D.Impulse);
        //    }
        //    ++i;
        //}

    }
}
