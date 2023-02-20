using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -5.0f;
    public static float rightSide = 5.0f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
