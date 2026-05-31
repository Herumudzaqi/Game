using UnityEngine;

public class ExitDoorController : MonoBehaviour
{
    public Transform exitDoor;

    public float openSpeed = 2f;

    private bool isOpen = false;

    private Quaternion targetRotation;

    void Start()
    {
        // Rotasi pintu terbuka
        targetRotation = Quaternion.Euler(0f, -90f, 0f);
    }

    void Update()
    {
        if (isOpen)
        {
            exitDoor.localRotation = Quaternion.Slerp(
                exitDoor.localRotation,
                targetRotation,
                Time.deltaTime * openSpeed
            );
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (
                BatteryPickup.hasBattery &&
                Input.GetKeyDown(KeyCode.E)
            )
            {
                isOpen = true;

                Debug.Log("Exit terbuka!");
            }
        }
    }
}