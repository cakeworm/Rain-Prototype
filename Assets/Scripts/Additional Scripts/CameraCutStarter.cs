using UnityEngine;
using System.Collections;

public class Temp : MonoBehaviour {

    public Camera mainCamera;
    public Camera orthoCamera;

    public void ShowOverheadView() {
        mainCamera.enabled = false;
        orthoCamera.enabled = true;
    }
    
    public void ShowFirstPersonView() {
        mainCamera.enabled = true;
        orthoCamera.enabled = false;
    }
}