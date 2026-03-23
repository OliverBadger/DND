using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class InputService : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Delegate(string input, string inputTag)
    {
        if (inputTag == "Direction")
            DirectionHandler(input);
    }

    public void DirectionHandler(string input) {
        bool moveable = true;
        if (input == "Right" && moveable)
            Debug.Log("Hokey Pokey");
        if (input == "Left" && moveable)
            Debug.Log("Pokey Hokey");
        if (input == "Down" && moveable)
            Debug.Log("Pokey Hokey");
        if (input == "Up" && moveable)
            Debug.Log("Jokey Monkey");
    }
}
