using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Instance.InMenu)
        {
            canvas.enabled = true;
        }
        else if (!Player.Instance.InMenu)
        {
            canvas.enabled = false;
        }
    }
}
