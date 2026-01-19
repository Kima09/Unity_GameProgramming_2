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

                if(instance == null)
                {
                    GameObject clone = new GameObject(nameof(GameManager));
                    instance = clone.AddComponent<GameManager>();
                }
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
    }

    void Start()
    {
        state = true;
        
    }

   
    public void Pause()
    {
        state = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
        }
    }
}
