using UnityEngine;

public class KeyPickup1 : MonoBehaviour
{
    public static bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;

            Debug.Log("Kunci didapat!");

            Destroy(gameObject);
        }
    }
}