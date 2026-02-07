using UnityEngine;

public class Notofication : MonoBehaviour
{

    private void OnEnable()
    {
        QuestManager.OnQuestCompleted += Show;
    }

    private void OnDisable()
    {
        QuestManager.OnQuestCompleted -= Show;
    }
    public void Show(Quest quest)
    {
        Debug.Log("Quest Name: " + quest.Title + " Cleared");
    }
}
