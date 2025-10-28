using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;       // The object to follow
    public float CameraSpeed = 5f; // How fast the camera moves

    // Camera movement limits (set these in the Inspector)
    public float minX, maxX;
    public float minY, maxY;

    void FixedUpdate()
    {
        if (Target != null)
        {
            // Smoothly move camera towards target
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CameraSpeed);

            // Clamp the camera's position so it doesn't go beyond bounds
            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);

            // Apply the final clamped position (keep z = -10 for 2D camera)
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    }
}










