using System;
public class Basic{
    int pos_x;
    int pos_y;

    // type tells if can be collided or not
    int obj_type;
    public int pos_x{
        get{
            return pos_x;
        }
        set{
            pos_x = value;
        }
    }

    public int pos_y{
        get{
            return pos_y;
        }
        set{
            pos_y = value;
        }
    }

    public int type{
        get{
            return obj_type;
        }
        set{
            obj_type = value;
        }
    }
}