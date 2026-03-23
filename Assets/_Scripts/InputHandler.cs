using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_camera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;

        InputService inputService = new InputService();

        inputService.Delegate(rayHit.collider.gameObject.name, rayHit.collider.gameObject.tag);

        Debug.Log(rayHit.collider.gameObject.name);
    }
}
