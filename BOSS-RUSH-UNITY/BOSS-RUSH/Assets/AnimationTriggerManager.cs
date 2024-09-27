using System;
using UnityEngine;
using UnityEngine.Events;

public class AnimationTriggerManager : MonoBehaviour
{
    public CustomEvent [] events;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvokeEvent(string name)
    {
        foreach(CustomEvent events in events)
        {
            if(events.eventName == name)
            {
                events.myEvent.Invoke();
            }
        }
    }
}

[Serializable]
public class CustomEvent
{
    public string eventName;
    public UnityEvent myEvent;
}
