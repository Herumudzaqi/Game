using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    public Transform door;

    public float openSpeed = 5f;

    private bool isOpen = false;

    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
        closedPosition = door.localPosition;

        // geser ke samping
        openPosition = closedPosition + new Vector3(0f, 0f, 0.8f);
    }

    void Update()
    {
        if (isOpen)
        {
            door.localPosition = Vector3.MoveTowards(
                door.localPosition,
                openPosition,
                openSpeed * Time.deltaTime
            );
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (
                KeyPickup2.hasKey2 &&
                Input.GetKeyDown(KeyCode.E)
            )
            {
                isOpen = true;

                Debug.Log("Pintu 2 dibuka!");
            }
        }
    }
}