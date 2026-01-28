using UnityEngine;
using System.Collections;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameObject Minotaur;
    [SerializeField] WaitForSeconds waitForSeconds;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(5.0f);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Create());
        
    }

    IEnumerator Create()
    {
        while (true)
        {
            GameObject clone = Instantiate(Minotaur);
            Vector2 direction = Random.insideUnitCircle.normalized * radius;
            clone.transform.position = new Vector3(direction.x, 0, direction.y);
            yield return waitForSeconds;
        }
           
    }
   
}
