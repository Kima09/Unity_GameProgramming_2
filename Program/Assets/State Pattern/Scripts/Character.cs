using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;

    [SerializeField] IStateable stateable;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stateable = new Idle();
        
    }

    // Update is called once per frame
    void Update()
    {
        stateable.Update(this);
        
    }

    public void SwitchState(IStateable state)
    {
        stateable.Exit(this);
        stateable = state;
        stateable.Enter(this);
    }
}
