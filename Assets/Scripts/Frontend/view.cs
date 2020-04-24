namespace Test
{
   
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    

    public class view
    {    
        public double timer = 0.0;
        public int frames = 24;//1/24s
        public Queue<string> storedInformation = new Queue<string>();
        // play system
        // every xxx ms play one frame 
        // time.deltaTime...?
        // Queue<String> storeInformation ...
        // incoming msg stores into queue 
        // play based on setting frames / second 

        GameObject g = new GameObject();
        public static void receiver(string msg)
        {

            // storedInformation.add(msg)

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
                Debug.Log(get_grid.grids[i].x);
                gm.SpawnTile(get_grid.grids[i].x, Mathf.Abs(rev - get_grid.grids[i].y), get_grid.grids[i].type, rev);
            }

            gm.Deletespawn();

                //Debug.Log(msg[0]);
            return;
        }

        public void play(){
            //time.deltatime...
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