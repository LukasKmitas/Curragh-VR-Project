using UnityEngine;

public class UIFacePlayer : MonoBehaviour
{
    public Transform playerTransform;

    private void Start()
    {
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
