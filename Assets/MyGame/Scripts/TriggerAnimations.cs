using UnityEngine;

public class TriggerAnimations : MonoBehaviour
{
    private const string animParamRotateLeft = "isSetToRotateLeft";
    private const string animParamRotateRight = "isSetToRotateRight";
    private const string animParamRotateInactive = "isSetToInactive";

    public Animator stateMachine;

    void Start ()
    {
        SetAnimationParamInactive ();
    }

    void SetAnimationParamInactive ()
    {
        stateMachine.ResetTrigger (animParamRotateLeft);
        stateMachine.ResetTrigger (animParamRotateRight);
        stateMachine.SetTrigger (animParamRotateInactive);
    }

    void SetAnimatinParamRotationToLeft ()
    {
        stateMachine.SetTrigger (animParamRotateLeft);
        stateMachine.ResetTrigger (animParamRotateRight);
        stateMachine.ResetTrigger (animParamRotateInactive);
    }

    void SetAnimationParamRotationToRight ()
    {
        stateMachine.ResetTrigger (animParamRotateLeft);
        stateMachine.SetTrigger (animParamRotateRight);
        stateMachine.ResetTrigger (animParamRotateInactive);
    }

    public void RotateRight ()
    {
        SetAnimationParamRotationToRight ();
        Debug.Log("Button pressed right");
    }

    public void RotateLeft()
    {
        SetAnimatinParamRotationToLeft ();
        Debug.Log("Button pressed left");
    }

    public void RotateStop()
    {
        SetAnimationParamInactive ();
        Debug.Log("Button pressed stop");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter" + other.name);
    }


}
