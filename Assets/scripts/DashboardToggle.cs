using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashboardToggle : MonoBehaviour
{
    public GameObject dashboard;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            dashboard.SetActive(!dashboard.activeSelf);
        }
    }
}
