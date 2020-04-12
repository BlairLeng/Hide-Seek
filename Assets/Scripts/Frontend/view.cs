namespace Test
{
   
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    

    public class view 
    {
        //-1 to separate
    
        public GameObject ob;
        public static void receiver(string msg)
        {
            MyClass get_grid = JsonUtility.FromJson<MyClass>(msg);

            Debug.Log(msg);
            Debug.Log(get_grid.grids[0].x);
            Debug.Log(get_grid.grids[1].x);




            //Debug.Log(msg[0]);
            return;

            //split
            //info1
            //call xxx function

            //info2 
            //call xxx function

            //....

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