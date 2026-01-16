using UnityEngine;

public class Knife : Weapons
{
    [SerializeField] Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public override void Attack()
    {
        animator.Play("KnifeAttack");
    }
}
