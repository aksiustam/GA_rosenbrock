using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GA_rosenbrock
{
    
    public class Pop
    {

        public static int penalty;
        private IList<Gen> kromozon = new List<Gen>();
        public IList<Gen> Kromozon
        {
            set { kromozon = value; }
            get { return kromozon; }
        }

        private Gen _bestgen;
        public Gen BestGen
        {
            get { return _bestgen; }
        }
        private double totalscore;
        public double Totalscore
        {
            get { return totalscore; }
        }
        public Pop(double Poplength)
        {
            poplengt = Poplength;
        }
        private double poplengt;

        public void ScoreAll()
        {
            _bestgen = null;
            foreach (Gen g in kromozon) // her kromozonun genine baq
            {
                g.Score = GA.solution(g);
                UpdateBestGenome(g);
                
                
            }
            
            
        }
        public static bool Compare(Gen a, Gen b)
        {
            return a.Score < b.Score;
        }
        private void UpdateBestGenome(Gen g)
        {
            if (_bestgen == null || g.Score < _bestgen.Score)
            {
                _bestgen = g;
            }

        }
        public void Updatetotalscore()
        {
            double a = 0;
            foreach (Gen h in kromozon)
            {
                a += h.Score;
            }
            totalscore = a;

        }
        public void Updatekumdeg()
        {
            int sayı = Kromozon.Count;
            for (int i = 0; i < sayı; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Kromozon[i].Kumdeg += Math.Round(Kromozon[j].Score / totalscore, penalty, MidpointRounding.ToEven);
                    
                }
                Kromozon[i].Kumdeg = Math.Round(Kromozon[i].Kumdeg, penalty, MidpointRounding.ToEven);
            }
            

        }
        public void Generate()
        {
            
            kromozon.Clear();
            _bestgen = null;

            for (int i = 0; i < poplengt; i++)
            {
                Gen genes = GA.GenRanGen(-30,30, 30);
                kromozon.Add(genes);

            }
        }


    }
}
