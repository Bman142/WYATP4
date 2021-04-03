using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


namespace WYATP.PlayerControl
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        public float MoveSpeed { get { return moveSpeed; } }

        private static Player instance = null;
        public static Player Instance { get { return instance; } }

        public enum controlScheme { WASD, Arrows }

        [SerializeField] private controlScheme control;
        public controlScheme Control { get { return control; } set { value = control; } }
        [Range(0, 100)]
        [SerializeField] private float cameraSensitivity;
        public float CameraSensitivty { get { return cameraSensitivity; } set { value = cameraSensitivity; } }

        private bool inMenu = false;
        public bool InMenu { get { return inMenu; } set { inMenu = value; } }

        private bool cursorLock = false;
        public bool CursorLock { get { return cursorLock; } set { cursorLock = value; } }

        private int volume;
        public int Volume { get { return volume; } set { volume = value; } }
        public enum levelEnding { Rebel, Government}
        [SerializeField] private levelEnding levelEnd;
        public levelEnding LevelEnd { get { return levelEnd; } set { levelEnd = value; } }

        private void Awake()
        {
            if (instance != null)
            {
                if (instance != this)
                {
                    Destroy(this);
                }
            }
            else
            {
                instance = this;
            }

            DontDestroyOnLoad(this);

            string temp = PlayerPrefs.GetString("Controls");
            if (temp == "WASD")
            {
                control = controlScheme.WASD;
            }
            else if (temp == "Arrows")
            {
                control = controlScheme.Arrows;
            }
            Volume = PlayerPrefs.GetInt("Volume");

            AudioSource[] audioSources = GameObject.FindObjectsOfType<AudioSource>();

            foreach(AudioSource source in audioSources)
            {
                Debug.Log(source.gameObject.name);
                source.volume *= Volume;
            }
        }
        public void SetInMenu()
        {
            cursorLock = !cursorLock;
        }

        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}