using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public PlayerInput teaInput;
    public PlayerInput waterInput;
    public GameObject teaBoy;
    public GameObject waterGirl;

    public BasicCameraTracker cameraTracker;

    private bool activePlayerTea;

    // Start is called before the first frame update
    void Start()
    {
        activePlayerTea = true;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("E pressed and value is "+activePlayerTea);
            if (activePlayerTea)
            {
                // switch to water
                waterInput.enabled = true;
                teaInput.enabled = false;
                cameraTracker.m_Target = waterGirl;
            }
            else
            {
                // switch to tea
                waterInput.enabled = false;
                teaInput.enabled = true;
                cameraTracker.m_Target = teaBoy;
            }
            activePlayerTea = !activePlayerTea;
        }
    }
}
