using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

namespace WYATP
{
    public class FinalDecisionScript : MonoBehaviour
    {
        [SerializeField] float cluesFound = 0;
        [SerializeField] Flowchart flowchart;
        bool executed = false;
        
        void Update()
        {
            if(cluesFound >= 3 && !executed)
            {
                flowchart.ExecuteBlock("Final Decision");
                executed = true;
            }
        }

        public void ClueFound()
        {
            cluesFound += 1;
        }
        public float CluesFound()
        {
            return cluesFound;
        }
        public void RebelEnd()
        {
            PlayerControl.Player.Instance.LevelEnd = PlayerControl.Player.levelEnding.Rebel;
        }
        public void GovernmentEnd()
        {
            PlayerControl.Player.Instance.LevelEnd = PlayerControl.Player.levelEnding.Government;
        }
    }
}