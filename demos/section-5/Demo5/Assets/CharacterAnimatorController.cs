using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    protected Animator animator;

    protected virtual void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    protected void SetWalkTrigger()
    {
        animator.SetBool("idle", false);
        animator.SetTrigger("walkTrig");
    }

    protected void SetJumpTrigger()
    {
        animator.SetBool("idle", false);
        animator.SetTrigger("jumpTrig");
    }
}
