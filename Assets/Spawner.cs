using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject routerPrefab;
    public GameObject laptopPrefab;
    public Transform spawnPoint;

    private List<GameObject> spawnedObjects = new List<GameObject>();

    // Function to handle router button click
    public void SpawnRouter()
    {
        GameObject router = Instantiate(routerPrefab, spawnPoint.position, Quaternion.identity);
        spawnedObjects.Add(router);
    }

    // Function to handle laptop button click
    public void SpawnLaptop()
    {
        GameObject laptop = Instantiate(laptopPrefab, spawnPoint.position, Quaternion.identity);
        spawnedObjects.Add(laptop);
    }

    // Function to handle reset button click
    public void ResetDesk()
    {
        foreach (GameObject obj in spawnedObjects)
        {
            Destroy(obj);
        }
        spawnedObjects.Clear();
    }

    // Function to handle main menu button click
    public void GoToMainMenu()
    {
        // Implement code to return to main menu
    }
}
