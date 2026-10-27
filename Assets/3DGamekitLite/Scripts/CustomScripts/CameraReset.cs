using UnityEngine;
using Cinemachine;

public class CameraReset : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook freeLookCamera;
    [SerializeField] private GameObject freeLookCameraObject;

    [SerializeField] private float startingAngle = 0f;
    

    private void Start()
    {
        if (freeLookCamera == null)
        {
            freeLookCamera = FindObjectOfType<CinemachineFreeLook>();
        }

        if (freeLookCamera != null)
        {
            freeLookCamera.m_XAxis.Value = startingAngle;
            Debug.Log("Reset Camera!");
        }
        else
        {
            Debug.LogWarning("No CinemachineFreeLook camera found.");
        }
    }

    public void CameraResetStart()
    {
        if (freeLookCamera == null)
        {
            freeLookCamera = GameObject.Find("KeyboardAndMouseFreeLookRig").GetComponent<CinemachineFreeLook>();
            freeLookCameraObject = GameObject.Find("KeyboardAndMouseFreeLookRig");
            
        }

        if (freeLookCamera != null)
        {
            freeLookCamera.m_XAxis.Value = startingAngle;
            //freeLookCameraObject.transform.rotation.y = gameObject.transform.rotation.y;
            Debug.Log("Reset Camera!");
        }
        else
        {
            Debug.LogWarning("No CinemachineFreeLook camera found.");
        }
    }
}
