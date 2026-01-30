using UnityEngine;
using System.Collections;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float duration;
    [SerializeField] WaitForSeconds waitForSeconds;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(duration);
        
    }

    private void Start()
    {
        StartCoroutine(Create());
    }
    
    IEnumerator Create()
    {
        while (true)
        {
            
            GameObject clone = ObjectPool.Instance.GetObject();
            Vector2 direction = Random.insideUnitCircle.normalized * radius;
            clone.transform.position = new Vector3(direction.x, 0, direction.y);
            clone.SetActive(true);

            yield return waitForSeconds;
        }
           
    }
   
}
