using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public InputActionReference showButton;
    
    // Start is called before the first frame update
    void Start()
    {
        // Enable the action
        showButton.action.Enable();
    }

    // Disable the action when the script is disabled
    void OnDisable()
    {
        showButton.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.triggered)
        {
            menu.SetActive(!menu.activeSelf);
        }
    }
}
