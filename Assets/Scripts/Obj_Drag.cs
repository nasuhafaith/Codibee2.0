using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Drag : MonoBehaviour
{
    public Vector2 SavePosition;
    public bool isAboveObj;

    Transform SaveObj;

    void Start()
    {
        SavePosition = transform.position;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseUp()
    {
        if (isAboveObj)
        {
            transform.SetParent(SaveObj);
            transform.localPosition = Vector3.zero;
        }
        else
        {
            transform.position = SavePosition; 
        }
    }

    private void OnMouseDrag()
    {
        Vector2 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Pos;
    }

    private void OnTriggerStay2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Drop"))
        {
            isAboveObj = true;
            SaveObj = trig.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Drop"))
        {
            isAboveObj = false;
        }
    }
}
