using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public static bool hasBattery = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasBattery = true;

            Debug.Log("Battery didapat!");

            Destroy(gameObject);
        }
    }
}