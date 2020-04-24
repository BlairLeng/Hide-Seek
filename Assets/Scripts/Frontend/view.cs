namespace Test
{
   
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    

    public class view : MonoBehaviour
    {            
        public static double timer = 0.0;
        public static int frames = 6;
        public static double waittime = (double)1/frames;

        public List<GameObject> tempObjects = new List<GameObject>();

        public static Queue<string> storedInformation = new Queue<string>();
        // play system
        // every xxx ms play one frame 
        // time.deltaTime...?
        // Queue<String> storeInformation ...
        // incoming msg stores into queue 
        // play based on setting frames / second 

        //GameObject g = new GameObject();
        public static void receiver(string msg)
        {

            // storedInformation.add(msg)
            storedInformation.Enqueue(msg);
            // MyClass get_grid = JsonUtility.FromJson<MyClass>(msg);

            //Debug.Log(msg);
            // //Debug.Log("x is "+get_grid.grids[0].x);
            // //Debug.Log("y is "+get_grid.grids[0].y);
            // //Debug.Log("type is "+ get_grid.grids[0].type);

            // GameObject gmob = new GameObject();
            // GridManger gm = gmob.AddComponent<GridManger>();
            // int len = get_grid.width * get_grid.height;
            // int rev = get_grid.height - 1;
            // for (int i = 0; i < len; i++)
            // {
            //     //Debug.Log(get_grid.grids[i].x);
            //     gm.SpawnTile(get_grid.grids[i].x, Mathf.Abs(rev - get_grid.grids[i].y), get_grid.grids[i].type, rev);
            // }

            // gm.Deletespawn();

                //Debug.Log(msg[0]);
            return;
        }

        void Update(){
            // Debug.Log("Hi");
            if (timer >= waittime && tempObjects.Count != 0 && storedInformation.Count != 0){
                for (int i = 0; i < tempObjects.Count; i++){
                    Destroy(tempObjects[i]);
                }
            }
            if (timer >= waittime && storedInformation.Count != 0){
                string msg = storedInformation.Dequeue();
                MyClass get_grid = JsonUtility.FromJson<MyClass>(msg);

                //Debug.Log(msg);
                //Debug.Log("x is "+get_grid.grids[0].x);
                //Debug.Log("y is "+get_grid.grids[0].y);
                //Debug.Log("type is "+ get_grid.grids[0].type);

                GameObject gmob = new GameObject();
                GridManger gm = gmob.AddComponent<GridManger>();
                int len = get_grid.width * get_grid.height;
                int rev = get_grid.height - 1;
                for (int i = 0; i < len; i++)
                {
                    //Debug.Log(get_grid.grids[i].x);
                    gm.SpawnTile(get_grid.grids[i].x, Mathf.Abs(rev - get_grid.grids[i].y), get_grid.grids[i].type, rev);
                }
                timer = 0;
                tempObjects = gm.pool1;
            }
            timer += Time.deltaTime;
            return;
        }


        [System.Serializable]
        public class MyClass
        {
            public int width;
            public int height;
            public List<gridData> grids;
        }


    }
}