using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] bool state;

    public bool State {  get { return state; } }

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
