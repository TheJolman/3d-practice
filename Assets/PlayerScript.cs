using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    // public Transform cameraTrasform;
        
    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction lookAction;
    private CharacterController controller;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller =  GetComponent<CharacterController>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        lookAction = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveValue.x, 0, moveValue.y);
        controller.Move(move * Time.deltaTime);

        if (jumpAction.IsPressed())
        {
            
        }

    }
}
