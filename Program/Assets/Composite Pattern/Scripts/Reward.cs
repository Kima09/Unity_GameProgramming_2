using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] Item [ ] dataList;

    [SerializeField] Image image;
    
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    void Start()
    {
        random = Random.Range(0, dataList.Length);
        gameObject.name = dataList[random].Name;
        image.sprite = dataList[random].GetSprite;
        
    }

}
