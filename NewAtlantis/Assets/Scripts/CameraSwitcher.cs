using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

    [SerializeField]
    private Camera[] cameras;
    private int currentCamera = 0;

    public void SwitchCamera(int CameraNumber)
    {
        cameras[currentCamera].enabled = false;
        cameras[CameraNumber].enabled = true;
        currentCamera = CameraNumber;
    }
}
