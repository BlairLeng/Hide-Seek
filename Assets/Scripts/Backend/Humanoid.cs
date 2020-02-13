using System;

public class Humanoid{
    int pos_x;
    int pos_y;

    double speed;

    // type tells if can be collided or not
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

    public double speed{
        get{
            return speed;
        }
        set{
            speed = value;
        }
    }

}