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
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
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
    }
}