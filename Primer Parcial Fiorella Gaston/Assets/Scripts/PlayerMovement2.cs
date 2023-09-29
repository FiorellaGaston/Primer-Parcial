using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float horizontal;
    public float vertical;

    public float thrustForce;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        // Direccion    * Magnitude   * Input    * DeltaTime.

        transform.position += transform.forward * thrustForce * vertical * Time.deltaTime;

        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);
     }
}
