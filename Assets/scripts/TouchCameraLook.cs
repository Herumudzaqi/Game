using UnityEngine;

public class TouchCameraLook : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Touch Count = " + Input.touchCount);

        foreach (Touch touch in Input.touches)
        {
            Debug.Log("Touch : " + touch.position);
        }
    }
}