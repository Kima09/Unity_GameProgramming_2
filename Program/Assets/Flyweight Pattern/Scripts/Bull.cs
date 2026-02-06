using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] AnimatorStateInfo animatorStateInfo;
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
    
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

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        

        yield return CoroutineCache.GetCachedWait(clipInfos[0].clip.length);

    }

    private IEnumerator Damnation()
    {
        animator.SetTrigger("Damnation");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        

        yield return CoroutineCache.GetCachedWait(clipInfos[0].clip.length);

    }

    private IEnumerator Paranoia()
    {
        animator.SetTrigger("Paranoia");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        

        yield return CoroutineCache.GetCachedWait(clipInfos[0].clip.length);

    }
}
