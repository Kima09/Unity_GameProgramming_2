using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] string[] patternName;

    [SerializeField] AnimatorStateInfo animatorStateInfo;
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        
    }

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

   

    IEnumerator Coroutine()
    {
        while(true)
        {
            yield return CoroutineCache.GetCachedWait(5);

            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            coroutine = StartCoroutine(Pattern(patternName[Random.Range(0,patternName.Length)]));
        }
    }

   

    private IEnumerator Pattern(string name)
    {
        animator.SetTrigger(name);

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);



        yield return CoroutineCache.GetCachedWait(clipInfos[0].clip.length);

    }


    
}
