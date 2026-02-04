using UnityEngine;

public class Walk : IStateable
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("x", 1);
        character.animator.SetInteger("y", 1);
    }

    public void Exit(Character character)
    {
        character.animator.SetInteger("x", 0);
        character.animator.SetInteger("y", 0);
    }

    public void Update(Character character)
    {
        int x = (int)Input.GetAxisRaw("Horizontal");
        int y = (int)Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }
        if ((x == 0) && (y == 0))
        {
            character.SwitchState(new Idle());
        }
        character.animator.SetInteger("x", x);
        character.animator.SetInteger("y", y);
    }
}
