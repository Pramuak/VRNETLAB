using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour
{
    public GameObject panel;
    public Image image;
    public GameObject laptop;
    public GameObject router;

    public Sprite yourImage; // Assign your image sprite in the Unity Editor

    void Start()
    {
        StartCoroutine(ShowPanelCoroutine());
    }

    IEnumerator ShowPanelCoroutine()
    {
        while (true)
        {
            yield return new WaitUntil(() => laptop != null && router != null); // Wait until both objects are spawned
            yield return new WaitForSeconds(5f); // Wait for 3 seconds after both objects are spawned
            ShowPanel();
            yield break; // Exit coroutine once the panel is shown
        }
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
        image.sprite = yourImage; // Set the image sprite
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }
}
