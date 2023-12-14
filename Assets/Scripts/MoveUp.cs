using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : Function_
{
    public MoveUp(string ID) : base(ID)
    {
        this.ID = ID;
    }
 
    override public void Func(GameObject mainTarget)
    {
        mainTarget.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10) * 5f);
    }
}
