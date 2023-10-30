using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayState : NatureBas
{
    private Material _material;
    
   
    Color lerpedColor = Color.black;
    public override void Enter(NatureStateMachine nature)
    {
        Debug.Log("DyaTime");
        
        _material = nature.transform.GetChild(0).GetComponent<MeshRenderer>().material;
       
    }
    public override void UpdateState(NatureStateMachine nature)
    {
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 10f));
        _material.color = lerpedColor;
        if (Input.GetKeyDown(KeyCode.A)) { nature.TransitionState(nature.eveningState); }
    }
    public override void TransitonState(NatureStateMachine nature)
    {
        
    }

    
}
