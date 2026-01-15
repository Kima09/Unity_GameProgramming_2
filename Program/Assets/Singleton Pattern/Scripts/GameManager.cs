using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;

    public bool State {  get { return state; } }

    [SerializeField] static GameManager instance;

    public static GameManager Instance
    {
        get 
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance; 
        }
    }

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    void Start()
    {
        state = true;
        
    }

   
    public void Pause()
    {
        state = false;
    }
}
