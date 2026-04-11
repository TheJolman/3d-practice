using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]
    private float lookSensitivity = 2f;
        
    private float xRotation = 0f;
    private Transform _t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _t = GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity;

        xRotation = -mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        _t.Rotate(Vector3.up * mouseX);

    }
}
