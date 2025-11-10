using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Animator animator;s
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("animator.Play");
    }
}
