using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WYATP
{
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
            if (PlayerControl.Player.Instance.InMenu)
            {
                canvas.enabled = true;
            }
            else if (!PlayerControl.Player.Instance.InMenu)
            {
                canvas.enabled = false;
            }
        }
    }
}