using UnityEngine;

public class UI_Interaction : MonoBehaviour
{
    public GameObject uiCanvas;

    public void ShowUI(string information)
    {
        // Show UI elements and set text/images based on information
        uiCanvas.SetActive(true);
        // Update UI elements with the provided information
    }

    public void HideUI()
    {
        // Hide UI elements
        uiCanvas.SetActive(false);
    }
}
