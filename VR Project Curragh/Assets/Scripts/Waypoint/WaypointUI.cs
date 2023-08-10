using UnityEngine;
using UnityEngine.UI;

public class WaypointUI : MonoBehaviour
{
    public GameObject uiCanvas; // Reference to the UI Canvas
    public float displayDuration = 2.0f; // How long the UI should be displayed in seconds

    private Button cylinderButton;
    private float displayTimer;
    private bool isUIVisible = false;

    private void Start()
    {
        cylinderButton = GetComponent<Button>();
        if (cylinderButton != null)
        {
            cylinderButton.onClick.AddListener(OnCylinderButtonClick);
        }
        else
        {
            Debug.LogWarning("Button component not found on the Cylinder object.");
        }

        uiCanvas.SetActive(false);
    }

    private void Update()
    {
        if (isUIVisible)
        {
            displayTimer += Time.deltaTime;
            if (displayTimer >= displayDuration)
            {
                ToggleUI(false);
            }
        }
    }

    private void OnCylinderButtonClick()
    {
        ToggleUI(!isUIVisible);
    }

    private void ToggleUI(bool show)
    {
        isUIVisible = show;
        uiCanvas.SetActive(show);
        displayTimer = 0.0f;
    }
}
