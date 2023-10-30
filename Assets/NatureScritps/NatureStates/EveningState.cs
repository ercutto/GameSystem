
using UnityEngine;

public class EveningState : NatureBas
{
    private Material _material;
    Color lerpedColor = Color.white;
    
    public override void Enter(NatureStateMachine nature)
    {
        
        _material = nature.transform.GetChild(0).GetComponent<MeshRenderer>().material;
        Debug.Log(nature.ToString());
        

    }
    public override void UpdateState(NatureStateMachine nature)
    {
        lerpedColor = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 10f));
        _material.color = lerpedColor;
       
        if (Input.GetKeyDown(KeyCode.A)) { nature.TransitionState(nature.dayState); }
    }
    public override void TransitonState(NatureStateMachine nature)
    {
        
    }

   
}
