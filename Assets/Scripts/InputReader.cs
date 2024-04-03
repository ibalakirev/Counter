using UnityEngine;

public class InputReader : MonoBehaviour
{
    public bool GetInputMouse()
    {
        int valueLeftMouseButton = 0;

        return Input.GetMouseButtonDown(valueLeftMouseButton);
    }
}
