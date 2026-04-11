using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private uint speed = 10;
    [SerializeField] private CharacterController cc;
    private Transform _cam;
    private float _verticalVelocity;
    private bool _isGrounded;
    void Start()
    {
        _cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = cc.isGrounded;
        if (_isGrounded && _verticalVelocity < 0f)
        {
            _verticalVelocity = -2f;
        }

        _verticalVelocity += Physics.gravity.y * Time.deltaTime;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        var move = _cam.right * h + _cam.forward * v;
        move.y = 0f;
        // var move = new Vector3(h, 0f, v);

        if (move.magnitude > 1f)
        {
            move.Normalize();
        }

        Vector3 velocity = move * speed + Vector3.up * _verticalVelocity;
        cc.Move(velocity * Time.deltaTime);
    }
}
