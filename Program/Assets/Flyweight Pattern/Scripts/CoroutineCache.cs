using System.Collections.Generic;
using UnityEngine;

public class CoroutineCache
{
    private static Dictionary<float, WaitForSeconds> dictionary = new Dictionary<float, WaitForSeconds>();
    
    public static WaitForSeconds GetCachedWait(float time)
    {
        WaitForSeconds waitForSeconds = null;

        if(dictionary.TryGetValue(time, out waitForSeconds)==false)
        {
            dictionary.Add(time, new WaitForSeconds(time));
            waitForSeconds = dictionary[time];
        }
        return waitForSeconds;
    }
}
