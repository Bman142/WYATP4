using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace WYATP
{
    public class SettingsManager : MonoBehaviour
    {
        [SerializeField] TMP_Dropdown controls;
        [SerializeField] Slider volume;
        string temp;
        int vol;
        private void Start()
        {
            PlayerPrefs.GetString("Controls");
            if(temp == "WASD")
            {
                controls.value = 0;
            }
            else if (temp == "Arrows")
            {
                controls.value = 1;
            }
            vol = PlayerPrefs.GetInt("Volume");
            volume.value = vol;
        }
        public void SaveSettings()
        {
            switch (controls.value)
            {
                case 0:
                    PlayerPrefs.SetString("Controls", "WASD");
                    break;
                case 1:
                    PlayerPrefs.SetString("Controls", "Arrows");
                    break;
            }
            PlayerPrefs.SetInt("Volume", vol);
        }
    }
}