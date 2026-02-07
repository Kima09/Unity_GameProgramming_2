using System;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
   public static event Action<Quest> OnQuestCompleted;
}
