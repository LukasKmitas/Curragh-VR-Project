using UnityEngine;

public class CylinderInteraction : MonoBehaviour
{
    public UI_Interaction uiInteraction;

    private void OnMouseDown()
    {
        // When the cylinder is clicked
        uiInteraction.ShowUI("Information about this cylinder");
    }
}
