using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class Grenade : Weapons
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 startPosition;
    [SerializeField] float throwingPower;
    [SerializeField] Vector3 direction;
   
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        
        startPosition = rigidbody.position;
    }

    public override void Attack()
    {
        if (rigidbody.useGravity == false)
        {
            rigidbody.useGravity = true;
            rigidbody.AddForce(direction.normalized * throwingPower, ForceMode.Impulse);
        }
    }
    private void OnBecomeInvisible()
    {
        rigidbody.useGravity = false;
        rigidbody.position = startPosition;
    }
}
