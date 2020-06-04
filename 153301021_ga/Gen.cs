using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GA_rosenbrock
{
    // Genler Kromozon1 = Gen [ X_1 , X_2 ]; // bizim problemde Gen [X_30] // d = 30 oldugundan 30 gen lazım
    public class Gen 
    {

        private double[] _genes;

        public Gen(int gensayı)
        {
            _genes = new double[gensayı];

        }

        public double[] Genes
        {
            get { return _genes; }
        }
        
        
        public double Score { get; set; }
        public double Kumdeg { get; set; }
        
       

    }
}
