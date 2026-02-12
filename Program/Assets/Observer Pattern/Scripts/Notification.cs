using UnityEngine;
using UnityEngine.UI;

public class Notofication : MonoBehaviour
{
    [SerializeField] Sprite sprite;
    [SerializeField] Canvas canvas;
    [SerializeField] Image questImage;

    private void Awake()
    {
        canvas = transform.GetChild(0).GetComponent<Canvas>();
        questImage = canvas.transform.GetChild(0).GetComponent<Image>();
    }
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
        if(quest.Completed)
        {
            canvas.gameObject.SetActive(true);

            questImage.sprite = sprite;

            Debug.Log("Quest Name: " + quest.Title + " Cleared");
        }
        
    }
}
