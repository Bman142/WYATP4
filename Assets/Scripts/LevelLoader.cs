using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WYATP
{
    public class LevelLoader : MonoBehaviour
    {
        [SerializeField] Animator transition;
        [SerializeField] float transitionTime = 1f;
        [SerializeField] GameObject governmentEnd;
        [SerializeField] GameObject rebelEnd;
        // Update is called once per frame
        void Awake()
        {
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Player"));
            }
            
        }

        private void Start()
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SetEndScene(PlayerControl.Player.Instance.LevelEnd);
            }
        }
        public void LoadNextLevel()
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }

        public void LoadPreviousLevel() { StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1)); }

        IEnumerator LoadLevel(int LevelIndex)
        {
            transition.SetTrigger("Start");

            yield return new WaitForSeconds(transitionTime);
            
            SceneManager.LoadScene(LevelIndex);
            
        }

        public void LoadSetLevel(int LevelIndex)
        {
            StartCoroutine(LoadLevel(LevelIndex));
        }

        void SetEndScene(PlayerControl.Player.levelEnding ending)
        {
            switch (ending)
            {
                case PlayerControl.Player.levelEnding.Rebel:
                    rebelEnd.SetActive(true);
                    break;

                case PlayerControl.Player.levelEnding.Government:
                    governmentEnd.SetActive(true);
                    break;
            }
        }
        
    }
}