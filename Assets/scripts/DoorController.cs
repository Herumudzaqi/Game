using UnityEngine;

public class DoorController : MonoBehaviour
{
    public static bool hasKey = false;

    public Transform leftDoor;
    public Transform rightDoor;

    public float openSpeed = 2f;

    private bool isOpen = false;

    private Vector3 leftOpenPos;
    private Vector3 rightOpenPos;

    void Start()
    {
        leftOpenPos = leftDoor.position + Vector3.left * 1.5f;
        rightOpenPos = rightDoor.position + Vector3.right * 1.5f;
    }

    void Update()
    {
        if (isOpen)
        {
            leftDoor.position = Vector3.Lerp(
                leftDoor.position,
                leftOpenPos,
                Time.deltaTime * openSpeed
            );

            rightDoor.position = Vector3.Lerp(
                rightDoor.position,
                rightOpenPos,
                Time.deltaTime * openSpeed
            );
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (hasKey && Input.GetKeyDown(KeyCode.E))
            {
                isOpen = true;

                Debug.Log("Pintu dibuka!");
            }
        }
    }
}