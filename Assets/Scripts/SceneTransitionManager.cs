using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public static SceneTransitionManager singleton;

    private void Awake()
    {
        if (singleton && singleton != this)
            Destroy(singleton);

        singleton = this;
    }

    public void GoToScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoToSceneAsync(int sceneIndex)
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
    }

    IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            yield return null;
        }

        operation.allowSceneActivation = true;
    }

    public void LoadPauseMenu()
    {
        if (SceneManager.GetActiveScene().name == "SampleSpace")
        {
            // Load the pause menu scene
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
            Time.timeScale = 0f; // Pause the game
        }
    }

    public void UnloadPauseMenu()
    {
        if (SceneManager.GetSceneByName("PauseMenu").isLoaded)
        {
            // Unload the pause menu scene
            SceneManager.UnloadSceneAsync("PauseMenu");
            Time.timeScale = 1f; // Resume the game
        }
    }

    void Update()
    {
        // Check for input from the Oculus VR controller's menu button
        if (OVRInput.GetDown(OVRInput.Button.Start) && SceneManager.GetActiveScene().name == "PauseMenu")
        {
            // Go back to SampleSpace scene
            GoToScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
