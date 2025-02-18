using System;
using UnityEngine;
using UnityEngine.Events;

public class AnimationTriggerManager : MonoBehaviour
{
    public UnityEvent [] events;

    public void InvokeEvent(int i)
    {
        events[i].Invoke();
    }
}
