using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (!Player.Instance.InMenu)
        {
            cameraSensitivity = Player.Instance.CameraSensitivty;
            Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
            mouseDirection += mouseChange;
            // Lock vertical field of view to approx. -45 to 90
            if (mouseDirection.y > 21.3) { mouseDirection.y = 21.3f; }
            else if (mouseDirection.y < 18) { mouseDirection.y = 18f; }
            this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.y * cameraSensitivity, Vector3.right);
        }
    }
}
