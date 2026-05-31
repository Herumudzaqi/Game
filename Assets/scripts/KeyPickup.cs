using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DoorController.hasKey = true;

            Debug.Log("Kunci didapat!");

            Destroy(gameObject);
        }
    }
}