using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private uint speed = 10;
    private CharacterController _cc;
    void Start()
    {
    _cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        var move = new Vector3(h, 0f, v);

        if (move.magnitude > 1f)
        {
            move.Normalize();
        }

        _cc.Move(move * (speed * Time.deltaTime));
    }
}
