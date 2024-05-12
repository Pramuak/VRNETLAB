using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CableConnector : MonoBehaviour
{
    public GameObject laptop;
    public GameObject router;

    private bool isLaptopConnected = false;
    private bool isRouterConnected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == laptop && !isLaptopConnected)
        {
            ConnectToLaptop();
        }
        else if (other.gameObject == router && !isRouterConnected)
        {
            ConnectToRouter();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == laptop && isLaptopConnected)
        {
            DisconnectFromLaptop();
        }
        else if (other.gameObject == router && isRouterConnected)
        {
            DisconnectFromRouter();
        }
    }

    private void ConnectToLaptop()
    {
        // Connect cable to laptop
        Debug.Log("Cable connected to laptop");
        isLaptopConnected = true;
    }

    private void ConnectToRouter()
    {
        // Connect cable to router
        Debug.Log("Cable connected to router");
        isRouterConnected = true;
    }

    private void DisconnectFromLaptop()
    {
        // Disconnect cable from laptop
        Debug.Log("Cable disconnected from laptop");
        isLaptopConnected = false;
    }

    private void DisconnectFromRouter()
    {
        // Disconnect cable from router
        Debug.Log("Cable disconnected from router");
        isRouterConnected = false;
    }
}
