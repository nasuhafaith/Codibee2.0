using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeft : Function_
{
    public MoveLeft(string ID) : base(ID)
    {
        this.ID = ID;
    }
 
    override public void Func(GameObject mainTarget)
    {
     
 
        mainTarget.GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 0) * 5f);
    }
}
