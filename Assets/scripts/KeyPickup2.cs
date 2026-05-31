using UnityEngine;

public class KeyPickup2 : MonoBehaviour
{
    public static bool hasKey2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey2 = true;

            Debug.Log("Kunci 2 didapat!");

            Destroy(gameObject);
        }
    }
}