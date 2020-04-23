
namespace Test{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class controller : MonoBehaviour
    {
        public string json = "";
        public List<gridData> runners = new List<gridData>();

        public bool send = true;
        map map = new map(10,10);
        RL rl = new RL();
        bool stop = false;
        void Start(){
            json = JsonUtility.ToJson(map);
            // map.runnerMove(0,"left");
            Debug.Log(json);
            view.receiver(json);
        }

        void Update()
        {
            
            map.read();
            rl.read();
            string order = rl.order();
            if (order == "left" && !stop){
                map.runnerMove(0,"left");
                json = JsonUtility.ToJson(map);
                view.receiver(json);
                Debug.Log(json);
            }
            stop = true;
        }
    }
}



