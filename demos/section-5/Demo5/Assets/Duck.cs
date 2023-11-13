using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : StateMachineBehaviour
{
    private Animator animator;

   

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.animator = animator;
        animator.SetBool("duck", true);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (Input.GetKeyUp(KeyCode.S))
        {
            // Set the "walk" parameter to true
            animator.SetBool("duck", false);
        }
    }

    // Other state machine callbacks...

    // You can also use other callbacks like OnStateExit, OnStateMove, and OnStateIK if needed.
}