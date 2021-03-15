using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Look at changing to Event System
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Player.Instance.InMenu = !Player.Instance.InMenu;
            Player.Instance.CursorLock = !Player.Instance.CursorLock;
        }
        if (Player.Instance.InMenu | Player.Instance.CursorLock)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else if (!Player.Instance.InMenu | !Player.Instance.CursorLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
