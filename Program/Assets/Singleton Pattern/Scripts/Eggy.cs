using UnityEngine;

public class Eggy : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 minScale = new Vector3(1, 1, 1);
    [SerializeField] Vector3 maxScale = new Vector3(2,2,2);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.State == false) return;

        float time = Mathf.PingPong(Time.time * speed, 1.0f);
        transform.localScale = minScale + (maxScale - minScale) * time;


    }
}
