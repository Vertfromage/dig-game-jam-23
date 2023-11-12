using UnityEngine;

public class Thrower : MonoBehaviour
{
    public GameObject objectToThrow;
    public float throwForce = 10f;
    public Transform throwPoint;

    void Update()
    {
    }

    public void ThrowObject()
    {
        GameObject thrownObject = Instantiate(objectToThrow, throwPoint.position, Quaternion.identity);

        Rigidbody rb = thrownObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Freeze rotation along the Z-axis
            rb.freezeRotation = true;

            // Apply force to throw the object up and to the left
            Vector3 throwDirection = new Vector3(-1f, 1f, 0f).normalized;  // Adjust these values for the desired direction
            rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Rigidbody component not found on the thrown object.");
        }
    }
}
