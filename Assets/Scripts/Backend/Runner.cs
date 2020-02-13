using System;

public class Runner : Humanoid{

    PublicSettings pubset = new PublicSettings();
    public Runner(int x, int y){
        pos_x = x;
        pos_y = y;
        speed = pubset.RUNNER_SPEED;
    }

    public double[] move(double x, double y){
        double[] r_list = new double[2];
        r_list[0] = x * this.speed;
        r_list[1] = y * this.speed;
        return r_list;
    }
}