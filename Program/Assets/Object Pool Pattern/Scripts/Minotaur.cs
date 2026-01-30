using UnityEngine;

public class Minotaur : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Transform portalTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        portalTransform = GameObject.Find("Portal").transform;
        transform.LookAt(portalTransform);
        direction = (portalTransform.position - transform.position).normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*speed*Time.deltaTime, Space.World);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Portal"))
        {
            ObjectPool.Instance.Return(gameObject);
        }
    }
}
