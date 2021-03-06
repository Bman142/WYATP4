using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace WYATP.PlayerControl
{
    [RequireComponent(typeof(Player))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 mouseDirection;
        private float cameraSensitivity;
        new Camera camera;

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
            camera = Camera.main;
            localSpeed = Player.Instance.MoveSpeed;
            agent = this.GetComponent<NavMeshAgent>();
            controls = Player.Instance.Control;

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
            localSpeed = Player.Instance.MoveSpeed;
            if (!Player.Instance.CursorLock)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit, 2))
                    {
                        //Debug.Log("Hit " + hit.collider.gameObject.GetComponent<Interactions.StoryItem>().ToString());
                        if (hit.collider.gameObject.tag == "Clue")
                        {
                            hit.collider.GetComponent<Interactions.Clue>().OnInteract();
                        }
                        else if (hit.collider.gameObject.tag == "Door")
                        {
                            hit.collider.GetComponent<Interactions.Door>().OnInteract();
                        }
                        else if (hit.collider.gameObject.tag == "StoryItem")
                        {
                            hit.collider.gameObject.GetComponent<Interactions.StoryItem>().OnInteract();
                            hit.collider.gameObject.GetComponent<Interactions.FrontDoor>().OnInteract();
                        }
                        else if(hit.collider.gameObject.tag == "PickUp")
                        {
                            hit.collider.GetComponent<Interactions.PickUp>().OnInteract();
                        }
                    }
                }


                cameraSensitivity = Player.Instance.CameraSensitivty;
                Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
                mouseDirection += mouseChange;
                this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.x, Vector3.up);


                if (Input.GetKey(forward)) { agent.Move(this.transform.forward * localSpeed); }
                if (Input.GetKey(backward)) { agent.Move(this.transform.forward * -localSpeed); }
                if (Input.GetKey(left)) { agent.Move(this.transform.right * -localSpeed); }
                if (Input.GetKey(right)) { agent.Move(this.transform.right * localSpeed); }
            }
        }
    }
}