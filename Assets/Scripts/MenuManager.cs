using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WYATP.Menu
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] Canvas menu;
        [SerializeField] Canvas settings;

        public void ChangeMenu(int ID)
        {
            if (ID == 0)
            {
                menu.gameObject.SetActive(true);
                settings.gameObject.SetActive(false);
            }
            else if (ID == 1)
            {
                menu.gameObject.SetActive(false);
                settings.gameObject.SetActive(true);
            }
        }
    }
}
