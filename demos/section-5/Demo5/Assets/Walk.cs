using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : StateMachineBehaviour
{
    private Animator animator;
    private GameObject targetObject;

   

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.animator = animator;
        targetObject = GameObject.FindObjectOfType<TargetObjectScript>()?.gameObject;
        animator.SetBool("walk", true);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (Input.GetKeyUp(KeyCode.W))
        {
            // Set the "walk" parameter to true
            animator.SetBool("walk", false);
        }
        else 
        {
            if (targetObject != null)
            {
                MoveGameObject(targetObject, .6f);
            }
        }
    }
    void MoveGameObject(GameObject obj, float dist)
    {
        obj.transform.Translate(Vector3.forward * dist);
    }

    // Other state machine callbacks...

    // You can also use other callbacks like OnStateExit, OnStateMove, and OnStateIK if needed.
}