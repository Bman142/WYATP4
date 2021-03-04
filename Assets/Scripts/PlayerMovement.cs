using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    private Vector2 mouseDirection;
    private float cameraSensitivity;


    float localSpeed;
    NavMeshAgent agent;

    Player.controlScheme controls;
    private KeyCode forward;
    private KeyCode backward;
    private KeyCode left;
    private KeyCode right;
    // Start is called before the first frame update
    void Start()
    {
        localSpeed = Player.Instatnce.MoveSpeed;
        agent = this.GetComponent<NavMeshAgent>();
        controls = Player.Instatnce.Control;

        switch (controls)
        {
            case Player.controlScheme.WASD:
                forward = KeyCode.W;
                backward = KeyCode.S;
                left = KeyCode.A;
                right = KeyCode.D;
                break;
            case Player.controlScheme.Arrows:
                forward = KeyCode.UpArrow;
                backward = KeyCode.DownArrow;
                left = KeyCode.LeftArrow;
                right = KeyCode.RightArrow;
                break;
        }
    }
        // Update is called once per frame


    void Update()
    {

        cameraSensitivity = Player.Instatnce.CameraSensitivty;
        Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
        mouseDirection += mouseChange;
        this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.x * cameraSensitivity, Vector3.up);


        if (Input.GetKey(forward)) { agent.Move(this.transform.forward * localSpeed); }
        if (Input.GetKey(backward)) { agent.Move(this.transform.forward * -localSpeed); }
        if (Input.GetKey(left)) { agent.Move(this.transform.right * -localSpeed); }
        if (Input.GetKey(right)) { agent.Move(this.transform.right * localSpeed); }
    }
}
