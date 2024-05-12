using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetObjects()
    {
        GameObject[] spawnedObjects = GameObject.FindGameObjectsWithTag("SpawnedObject");
        foreach (GameObject obj in spawnedObjects)
        {
            Destroy(obj);
        }
    }
}
