using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{

    bool isPaused = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeToScene(string SceneToChangeTo)
    {
        Application.LoadLevel(SceneToChangeTo);

    }
    public void RestartScene(string SceneToChangeTo)
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(SceneToChangeTo);

    }
    public void PauseScene(string SceneToChangeTo)
    {
        if (isPaused == true)
        {
            Time.timeScale = 1.0f;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0.0f;
            isPaused = true;
        }



    }
}