using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRight : Function_
{
    public MoveRight(string ID) : base(ID)
    {
        this.ID = ID;
    }
 
    override public void Func(GameObject mainTarget)
    {
   
        mainTarget.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 0)* 50f); //Add force when something trigger it to move drag and drop
    }
}
