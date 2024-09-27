using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public bool isCursorNeeded = true;
    // Update is called once per frame
    void Update()
    {
        CheckCursor();
    }

    private void CheckCursor()
    {
        if (isCursorNeeded)
        {
            CursorOn();
        }

        else
        {
            CursorOff();
        }
    }

    private void CursorOff()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    public void CursorOn()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
