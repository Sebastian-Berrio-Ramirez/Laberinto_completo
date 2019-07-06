using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : StateMachineBehaviour
{
    public float m_damping = 0.15f;

    readonly int m_HasHorizontalparam = Animator.StringToHash("Horizontal");
    readonly int m_HasVerticalParam = Animator.StringToHash("Vertical");
    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector2 input = new Vector2(horizontal, vertical).normalized;
        animator.SetFloat(m_HasHorizontalparam, 0, m_damping, Time.deltaTime);
        animator.SetFloat(m_HasVerticalParam, 1, m_damping, Time.deltaTime);
    }
}
