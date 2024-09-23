using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    public abstract void InStart();

    public abstract void InUpdate(float deltaTime);

    public abstract void OnExit();

}
