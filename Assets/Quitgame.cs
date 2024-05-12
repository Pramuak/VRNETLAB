using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        Button quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(Quit);
    }

    void Quit()
    {
        Debug.Log("Quitting game...");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
