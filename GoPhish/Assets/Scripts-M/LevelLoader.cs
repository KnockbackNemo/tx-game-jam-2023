using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime;
    public string nextScene;
  
    // Update is called once per frame
    void Update()
    {
        
    }



    // Load the next scene in the build index
    public void LoadNextLevel() {
        // StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        StartCoroutine(LoadLevel(nextScene));
    }

    IEnumerator LoadLevel(string levelName) {
        // Play animation
        transition.SetTrigger("Start");

        // Wait for animation

        yield return new WaitForSeconds(transitionTime);

        // Load next scene
        SceneManager.LoadScene(levelName);
    }
}
