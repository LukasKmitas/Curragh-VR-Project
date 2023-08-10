using UnityEngine;

public class UIFacePlayer : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's Transform

    private void Start()
    {
        // You can find the player's Transform by tagging the player GameObject as "Player" or assigning it directly in the Inspector.
        if (playerTransform == null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                playerTransform = player.transform;
            }
            else
            {
                Debug.LogWarning("Player Transform not assigned and no GameObject with the 'Player' tag found.");
            }
        }
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            // Make the UI face the player's position
            Vector3 playerDirection = playerTransform.position - transform.position;
            Quaternion newRotation = Quaternion.LookRotation(playerDirection);
            transform.rotation = newRotation;
        }
    }
}
