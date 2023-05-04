using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float speed = 2.0f;
    public float rotationSpeed = 100f;

    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    void Update()
    {
        float yPos = startPos.y + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);

        float rotY = startRot.eulerAngles.y + rotationSpeed * Time.time;
        transform.rotation = Quaternion.Euler(new Vector3(startRot.eulerAngles.x, rotY, startRot.eulerAngles.z));
    }
}
