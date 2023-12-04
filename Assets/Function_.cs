using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_ : MonoBehaviour
{
    public string ID;
 
    //contructor for simple functions
    public Function_(string ID)
    {
        this.ID = ID;
    }
 
    public virtual void Func(GameObject mainTarget)
    {
 
    }
 
}
