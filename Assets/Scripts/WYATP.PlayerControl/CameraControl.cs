using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WYATP.PlayerControl
{
    public class CameraControl : MonoBehaviour
    {
        private Vector2 mouseDirection;
        private float cameraSensitivity;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!Player.Instance.CursorLock)
            {
                cameraSensitivity = Player.Instance.CameraSensitivty;
                Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
                mouseDirection += mouseChange;
                //Debug.Log(mouseDirection);
                // Lock vertical field of view to approx. -45 to 90
                if (mouseDirection.y > 2) { mouseDirection.y = 2f; }
                else if (mouseDirection.y < -2) { mouseDirection.y = -2f; }
                this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.y * cameraSensitivity, Vector3.right);
            }
        }
    }
}