using UnityEngine;
using Cinemachine;

public class CameraReset : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook freeLookCamera;

    private void Start()
    {
        if (freeLookCamera == null)
        {
            GameObject cameraObject = GameObject.Find("KeyboardAndMouseFreeLookRig");

            if (cameraObject != null)
            {
                freeLookCamera = cameraObject.GetComponent<CinemachineFreeLook>();
            }
        }
    }

    public void CameraResetStart()
    {
        if (freeLookCamera != null)
        {
            // Get the player's facing direction in degrees
            float playerFacingAngle = transform.eulerAngles.y;

            // Set the camera's horizontal axis to match
            freeLookCamera.m_XAxis.Value = playerFacingAngle;

            Debug.Log("Camera reset to player facing direction!");
        }
        else
        {
            Debug.LogWarning("No CinemachineFreeLook camera found.");
        }
    }
}