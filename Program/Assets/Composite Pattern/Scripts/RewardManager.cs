using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int creationCount;
    [SerializeField] Bundle bundle;

    [SerializeField] Reward reward;
    [SerializeField] GameObject panel;
    [SerializeField] Transform parentTransform;

    private void Awake()
    {
        creationCount = Random.Range(1, 5);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Create();
        
    }

    // Update is called once per frame
    void Create()
    {
        for (int i = 0; i < creationCount; i++)
        {
            bundle.Add(Instantiate(reward, parentTransform));
        }
        
    }

    public void Accept()
    {
        bundle.Receive();
        panel.SetActive(false);
    }
}
