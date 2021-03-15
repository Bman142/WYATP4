using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public float MoveSpeed { get { return moveSpeed; } }

    private static Player instance = null;
    public static Player Instance { get { return instance; } }

    public enum controlScheme { WASD, Arrows}

    [SerializeField] private controlScheme control;
    public controlScheme Control { get { return control; } set { value = control; } }
    [Range(0, 100)]
    [SerializeField] private float cameraSensitivity;
    public float CameraSensitivty { get { return cameraSensitivity; } set { value = cameraSensitivity; } }

    private bool inMenu = false;
    public bool InMenu { get { return inMenu; } set { inMenu = value; } }

    private bool cursorLock = false;
    public bool CursorLock { get { return cursorLock; } set { cursorLock = value; } }

    private void Awake()
    {
        if(instance != null)
        {
            if(instance != this)
            {
                Destroy(this);
            }
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this);
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
