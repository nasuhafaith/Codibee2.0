using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLoop: MonoBehaviour //This is the loop
{
    GameObject mainTarget;
    List<Function_> sequence_; //After add all the movement from the trasnsform parent
    public bool infiniteLoop;
    public bool end;
    private float waitTime;
 
    public MainLoop(GameObject mainTarget, List<Function_> sequence_)
    {
        this.end = false;
        //this.moveSpeed = MoveSpeed;
        this.mainTarget = mainTarget;
        this.sequence_ = sequence_;
        this.waitTime = 2f; //wait time between functions in sequence (list)
 
    }
    public IEnumerator Play()
    {
        foreach (var sequence in this.sequence_)
        {
            Debug.Log(sequence);
        }
 
        WaitForSeconds wait = new WaitForSeconds(waitTime);
        this.end = true;
        foreach (Function_ fun in this.sequence_)
        {
            fun.Func(this.mainTarget);
 
        }
        yield return wait;
        this.end = true;
    }
 
}