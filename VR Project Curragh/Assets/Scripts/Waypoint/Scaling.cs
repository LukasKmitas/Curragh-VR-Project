using UnityEngine;

public class Scaling : MonoBehaviour
{
    public Transform player;
    public float maxDistance = 10f;
    public float minScale = 0.5f;
    public float maxScale = 2f;

    private Vector3 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        float normalizedDistance = Mathf.Clamp01(distance / maxDistance);
        float scale = Mathf.Lerp(minScale, maxScale, 1f - normalizedDistance);
        transform.localScale = initialScale * scale;
    }
}
