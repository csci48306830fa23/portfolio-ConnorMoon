using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour
{

    
    private GameObject targetObject;

    private Animator animator;


   

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.animator = animator;
        targetObject = GameObject.FindObjectOfType<TargetObjectScript>()?.gameObject;
        animator.SetBool("idle", true);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Set the "walk" parameter to true
            animator.SetBool("idle", false);
            animator.SetTrigger("walkTrig");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Trigger a transition to a new animation state
            animator.SetBool("idle", false);
            animator.SetTrigger("duckTrig"); // Replace "YourTransitionTrigger" with the actual trigger parameter name
        }
        // Check if the specified key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger a transition to a new animation state
            animator.SetBool("idle", false);
            animator.SetTrigger("jumpTrig"); // Replace "YourTransitionTrigger" with the actual trigger parameter name
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Trigger a transition to a new animation state
            animator.SetBool("idle", false);
            animator.SetTrigger("turnRTrig"); // Replace "YourTransitionTrigger" with the actual trigger parameter name
            if (targetObject != null)
            {
                RotateGameObject(targetObject, 20f);
               
                animator.SetBool("idle", true);

            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Trigger a transition to a new animation state
            animator.SetBool("idle", false);
            animator.SetTrigger("turnLTrig"); // Replace "YourTransitionTrigger" with the actual trigger parameter name
            if (targetObject != null)
            {
                RotateGameObject(targetObject, -20f);
               
                animator.SetBool("idle", true);

            }
        }
    }
    void RotateGameObject(GameObject obj, float angle)
    {
        obj.transform.Rotate(Vector3.up, angle);
    }
   



    // Other state machine callbacks...

    // You can also use other callbacks like OnStateExit, OnStateMove, and OnStateIK if needed.
}