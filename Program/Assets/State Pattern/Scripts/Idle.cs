using UnityEngine;

public class Idle : IStateable
{
    public void Enter(Character character)
    {
        Debug.Log("Idle Enter");
    }

    public void Exit(Character character)
    {
        Debug.Log("Idle Exit");
    }

    public void Update(Character character)
    {
        Debug.Log("Idle Update");
    }
}
