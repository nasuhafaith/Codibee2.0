using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDrop : MonoBehaviour, IDropHandler
{
    // Reference to the Controller script
    public Controller controller;

    public void OnDrop(PointerEventData eventData) 
    {
        UIDrag d = eventData.pointerDrag.GetComponent<UIDrag>();

        if (d != null)
        {
            // Check the name or tag of the dropped object to determine the movement command
            switch (eventData.pointerDrag.name)
            {
                case "MoveUp": // Assuming the dragged object is named "MoveRight"
                    // Communicate with the Controller script to add MoveRight to the sequence
                    controller.AddMovementCommand("MoveUp");
                    break;

                case "MoveLeft": // Similarly for other movements
                    controller.AddMovementCommand("MoveLeft");
                    break;

                // Add cases for other movement commands...

                default:
                    break;
            }

            d.parentToReturnTo = this.transform;
        }
    }
}

