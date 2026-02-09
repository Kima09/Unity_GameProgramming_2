using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : Singleton<QuestManager>
{
   public static event Action<Quest> OnQuestCompleted;

    [SerializeField] List<Quest> questList = new List<Quest>();

    public void Accept(Quest quest)
    {
        if(quest == null || questList.Contains(quest))
        {
            return;
        }

        questList.Add(quest);
    }
}
