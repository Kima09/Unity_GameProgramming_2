using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        coroutine = StartCoroutine(Smash());

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            coroutine = StartCoroutine(Damnation());
        }
    }
    

    private IEnumerator Smash()
    {
        animator.SetTrigger("Smash");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Smash Exit");
    }

    private IEnumerator Damnation()
    {
        animator.SetTrigger("Damnation");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Damnation Exit");
    }
}
