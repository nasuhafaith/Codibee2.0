using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) 
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped on "+ gameObject.name);
        UIDrag d = eventData.pointerDrag.GetComponent<UIDrag>();
        
        //idk what is this for...
        if( d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }
}
