using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDown : Function_
{
    public MoveDown(string ID) : base(ID)
    {
        this.ID = ID;
    }
 
    override public void Func(GameObject mainTarget)
    {
        mainTarget.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10) * 5f);
    }
}
