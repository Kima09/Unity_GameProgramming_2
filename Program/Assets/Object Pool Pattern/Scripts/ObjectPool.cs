using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : Singleton<ObjectPool>
{
    [SerializeField] int createCount;
    
    [SerializeField] Queue<GameObject> queue = new Queue<GameObject>();

    private void Awake()
    {
        createCount = 5;
    }

    private void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Create()
    {
        for(int i = 0; i < createCount; i++)
        {
            GameObject clone = Instantiate(Resources.Load<GameObject>("Minotaur"));
            clone.transform.SetParent(transform);
            clone.SetActive(false);
            queue.Enqueue(clone);
        
        }
    }

    public GameObject GetObject()
    {
        GameObject clone = null;

        if (queue.Count > 0)
        {
            clone = queue.Dequeue();
        }
        else
        {
            queue.Enqueue(Instantiate(Resources.Load<GameObject>("Minotaur")));

            clone = queue.Dequeue();

            clone.transform.SetParent(transform);

            clone.SetActive(false);

        
        }
        return clone;
    }
    public void Return(GameObject clone)
    {
        clone.SetActive(false);
        queue.Enqueue(clone);
    }
}
