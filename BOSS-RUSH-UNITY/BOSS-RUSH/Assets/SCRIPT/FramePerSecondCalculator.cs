using UnityEngine;


public enum FRAMERATE
{
    F60,F50,F30,F25,F24
}
public class FramePerSecondCalculator : MonoBehaviour
{
    public FRAMERATE frameRate;
    public float oneFrameInSeconds;
    float frameRateFloat;
    private void Update()
    {
        if(frameRate == FRAMERATE.F60)
        {
            frameRateFloat = 60;
        }


        if (frameRate == FRAMERATE.F50)
        {
            frameRateFloat = 50;
        }


        if (frameRate == FRAMERATE.F30)
        {
            frameRateFloat = 30;
        }


        if (frameRate == FRAMERATE.F25)
        {
            frameRateFloat = 25;
        }


        if (frameRate == FRAMERATE.F24)
        {
            frameRateFloat = 24;
        }
        oneFrameInSeconds = 1/frameRateFloat;
    }
}