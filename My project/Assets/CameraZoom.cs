using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera Cam;
    public float TargetZoom = 3f;
    private float ScrollData;
    public float ZoomSpeed = 3f;

    void Start()
    {
        Cam = GetComponent<Camera>();
        TargetZoom = Cam.orthographicSize;
    }

    void Update()
    {
        // Get mouse scroll wheel input
        ScrollData = Input.GetAxis("Mouse ScrollWheel");
        
        // Update target zoom based on scroll input
        TargetZoom = TargetZoom - ScrollData;
        
        // Clamp the zoom to avoid extreme values
        TargetZoom = Mathf.Clamp(TargetZoom, 3f, 6f);
        
        // Smoothly interpolate to the target zoom
        Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, TargetZoom, Time.deltaTime * ZoomSpeed);
    }
}
