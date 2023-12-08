

namespace NormalsToTheSurfaceOfATriaxialEllipsoid
{
    internal class Elipse
    {
        private double X;
        private double Y;
        private double Z;
        private double Fi;
        private double Ksi;
        private double N;
        private double dXksi;
        private double dYksi;
        private double dZksi;
        private double dXfi;
        private double dYfi;
        private double dZfi;

        #region
        public double x
        {
            get
            {
                return X;
            }
            set
            {
                X = value; 
            }
        }

        public double y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }

        public double z
        {
            get
            {
                return Z;
            }
            set
            {
                Z = value;
            }
        }

        public double fi
        {
            get
            {
                return Fi;
            }
            set
            {
                Fi = value;
            }
        }

        public double ksi
        {
            get
            {
                return Ksi;
            }
            set
            {
                Ksi = value;
            }
        }

        public double n
        {
            get
            {
                return N; 
            }
            set
            {
                N = value;
            }
        }

        public double dxksi
        {
            get
            {
                return dXksi;
            }
            set
            {
                dXksi = value;
            }
        }

        public double dyksi
        {
            get
            {
                return dYksi; 
            }
            set
            {
                dYksi = value;
            }
        }

        public double dzksi
        {
            get
            {
                return dZksi;
            }
            set
            {
                dZksi = value;
            }
        }

        public double dxfi
        {
            get
            {
                return dXfi;
            }
            set
            {
                dXfi = value;
            }
        }

        public double dyfi
        {
            get
            {
                return dYfi;
            }
            set
            {
                dYfi = value;
            }
        }

        public double dzfi
        {
            get
            {
                return dZfi; 
            }
            set
            {
                dZfi = value; 
            }
        }
        #endregion
    }
}