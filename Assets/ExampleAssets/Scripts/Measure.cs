using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Measure : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex +2);
    }

    // Update is called once per frame
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
