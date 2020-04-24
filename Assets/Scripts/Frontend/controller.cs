
namespace Test{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class controller : MonoBehaviour
    {
        public static double timer = 0.0;
        public static int frames = 6;

        public static double waittime = (double)1/frames;
        public string json = "";
        public List<gridData> runners = new List<gridData>();

        public bool send = true;
        map map = new map(10,10);
        runnerRL runnerRL = new runnerRL();
        chaserRL chaserRL = new chaserRL();
        bool stop = false;
        void Start(){
            json = JsonUtility.ToJson(map);
            // map.runnerMove(0,"left");
            //Debug.Log(json);
            view.receiver(json);
        }

        void Update()
        {
            map.read();
            runnerRL.read();
            chaserRL.read();
            string runner_order = runnerRL.order();
            string chaser_order = chaserRL.order();
            if (runner_order == "left"){
                map.runnerMove(0,"left");
                json = JsonUtility.ToJson(map);
                view.receiver(json);
                //Debug.Log(json);
            }
            if (chaser_order == "left"){
                map.chaserMove(0,"left");
                json = JsonUtility.ToJson(map);
                view.receiver(json);
                //Debug.Log(json);
            }
            //Debug.Log(timer);
        }
    }
}




            // if (timer >= waittime){
            //     map.read();
            //     runnerRL.read();
            //     chaserRL.read();
            //     string runner_order = runnerRL.order();
            //     string chaser_order = chaserRL.order();
            //     if (runner_order == "left"){
            //         map.runnerMove(0,"left");
            //         json = JsonUtility.ToJson(map);
            //         view.receiver(json);
            //         //Debug.Log(json);
            //     }
            //     if (chaser_order == "left"){
            //         map.chaserMove(0,"left");
            //         json = JsonUtility.ToJson(map);
            //         view.receiver(json);
            //         //Debug.Log(json);
            //     }
            //     //Debug.Log(timer);
            //     timer = 0;
            // }
            // timer += Time.deltaTime;