class PublicSettings
    {        
        public static double RUNNER_SPEED = 5.0;
        public static double CHASER_SPEED = 7.0;
        public double RUNNER_SPEED{
            get{    
                return RUNNER_SPEED;
            }
            set{
                RUNNER_SPEED = value;
            }
        }
        public double CHASER_SPEED{
            get{
                return CHASER_SPEED;
            }
            set{
                CHASER_SPEED = value;
            }
        }

    }