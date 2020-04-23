namespace Test
{
   
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    

    public class view
    {
        


        GameObject g = new GameObject();
        public static void receiver(string msg)
        {
            MyClass get_grid = JsonUtility.FromJson<MyClass>(msg);

            // Debug.Log(msg);
            //Debug.Log("x is "+get_grid.grids[0].x);
            //Debug.Log("y is "+get_grid.grids[0].y);
            //Debug.Log("type is "+ get_grid.grids[0].type);

            GameObject gmob = new GameObject();
            GridManger gm = gmob.AddComponent<GridManger>();
            gm.SpawnTile(get_grid.grids[0].x, get_grid.grids[0].y, get_grid.grids[0].type);
            int len = get_grid.width * get_grid.height;
            Random random = new Random();
            int rd = Random.Range(0,2);
            for (int i = 0; i < len; i++)
            {
                gm.SpawnTile(get_grid.grids[i].x, get_grid.grids[i].y, Random.Range(0, 2));
            }



                //Debug.Log(msg[0]);
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