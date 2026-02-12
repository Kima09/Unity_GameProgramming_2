using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
    [SerializeField] string[] questTitle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(Random.Range(0, questTitle.Length).ToString());

            QuestManager.Instance.Complete(questTitle[Random.Range(0, questTitle.Length)]);
        }
    }

    
}
