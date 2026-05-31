using UnityEngine;

public class BatteryPickup1 : MonoBehaviour
{
    public static int batteryHeld = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            batteryHeld++;

            Debug.Log("Battery diambil!");
            Debug.Log("Battery dibawa: " + batteryHeld);

            Destroy(gameObject);
        }
    }
}