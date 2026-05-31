using UnityEngine;

public class ExitDoorController1 : MonoBehaviour
{
    public Transform exitDoor;

    public float openSpeed = 2f;

    private bool isOpen = false;

    private Quaternion targetRotation;

    // jumlah battery yang sudah dipasang
    private int insertedBattery = 0;

    void Start()
    {
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
            // tekan E untuk memasang battery
            if (Input.GetKeyDown(KeyCode.E))
            {
                // kalau player masih punya battery
                if (BatteryPickup1.batteryHeld > 0)
                {
                    BatteryPickup1.batteryHeld--;

                    insertedBattery++;

                    Debug.Log(
                        "Battery dipasang: " +
                        insertedBattery +
                        "/2"
                    );

                    // kalau sudah 2 battery
                    if (insertedBattery >= 2)
                    {
                        isOpen = true;

                        Debug.Log("Exit terbuka!");
                    }
                }
                else
                {
                    Debug.Log("Tidak punya battery!");
                }
            }
        }
    }
}