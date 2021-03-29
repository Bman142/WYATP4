using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WYATP
{
    public class SceneChanger : MonoBehaviour
    {
        public void ChangeScene(int buildIndexID)
        {
            SceneManager.LoadScene(buildIndexID);
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void DestroyPlayer(GameObject player)
        {
            Destroy(player);
        }
        public void EndGame()
        {
            ChangeScene(0);
            DestroyPlayer(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
