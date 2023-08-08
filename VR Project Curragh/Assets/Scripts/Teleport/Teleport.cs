using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 teleportCoordinates = new Vector3(500f, 40f, 500f);

    private void Start()
    {
        Button teleportButton = GetComponent<Button>();
        teleportButton.onClick.AddListener(TeleportPlayer);
    }

    public void TeleportPlayer()
    {
        playerTransform.position = teleportCoordinates;
    }
}
