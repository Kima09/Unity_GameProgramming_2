using UnityEngine;

public class Rifle : Weapons
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform createPosition;
    public override void Attack()
    {
        Instantiate(bullet, createPosition);
    }

   
}
