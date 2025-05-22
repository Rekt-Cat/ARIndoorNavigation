using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SetCameraToEntrance : MonoBehaviour
{
    [SerializeField]private Transform xrOrigin;        // Drag your XR Origin here
    [SerializeField]private Transform entrancePoint;   // Drag your EntrancePoint here

    private void Start()
    {
        MoveXRCameraToEntrance();
    }

    void MoveXRCameraToEntrance()
    {
        // Move XR Origin to match entrance
        xrOrigin.position = entrancePoint.position;
        xrOrigin.rotation = entrancePoint.rotation;
    }
}
