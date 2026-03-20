using UnityEngine;

public class PlayerClicker : MonoBehaviour
{
    public GameObject House;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition == House.transform.position)
            {
                Debug.Log("Mouse 0 - Left");
            }
        }
    }
}
