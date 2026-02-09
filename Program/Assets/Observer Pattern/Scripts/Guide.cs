using UnityEngine;
using UnityEngine.UI;

public class Guide : MonoBehaviour
{
    [SerializeField] Quest quest;
    [SerializeField] Canvas questCanvas;

    private void Awake()
    {
        questCanvas = transform.GetChild(0).GetComponent<Canvas>();
    }

    public void Accept()
    {
        QuestManager.Instance.Accept(quest);
        questCanvas.gameObject.SetActive(false);
    }
}
