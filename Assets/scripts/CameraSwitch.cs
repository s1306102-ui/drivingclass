using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject thirdPersonCamera;
    public GameObject firstPersonCamera;

    private bool firstPerson = false;

    void Start()
    {
        thirdPersonCamera.SetActive(true);
        firstPersonCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            firstPerson = !firstPerson;

            thirdPersonCamera.SetActive(!firstPerson);
            firstPersonCamera.SetActive(firstPerson);
        }
    }
}      