using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WYATP.PlayerControl
{
    public class CameraControl : MonoBehaviour
    {
        private Vector2 mouseDirection;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!Player.Instance.CursorLock)
            {
                Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
                mouseDirection += mouseChange;
                //Debug.Log(mouseDirection);
                //Debug.Log(mouseChange);
                // Lock vertical field of view to approx. -45 to 90
                if (mouseDirection.y > 40) { mouseDirection.y = 40f; }
                else if (mouseDirection.y < -40) { mouseDirection.y = -40f; }
                this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.y, Vector3.right);
            }
        }
    }
}