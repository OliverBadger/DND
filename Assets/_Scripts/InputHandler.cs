using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _camera;
    private GameObject player;
    private PlayerLocation playerLocation;
    private GameObject bar;
    private OpenBarHandler openBarHandler;

    private void Awake()
    {
        _camera = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
        playerLocation = player.GetComponent<PlayerLocation>();
        bar = GameObject.FindGameObjectWithTag("Bar");
        openBarHandler = bar.GetComponent<OpenBarHandler>();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_camera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;

        if(rayHit.collider.gameObject.CompareTag("Bar"))
        {
            playerLocation.locationString = "Bar";
            openBarHandler.OpenBar();
        }
    }
}
