using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GA_rosenbrock
{

    class GA
    {

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static double RandomNumber(int min, int max) // Random saat tick ine göre işliyo 
        {
            lock (syncLock) // 
            { // synchronize
                return Math.Round((random.NextDouble() * (max - min) + min), Pop.penalty); // tick işlemesi çok fazla oldugundan bu kodu yazıyoz
            } // deyse sürekli aynı sayıları elde ederiz.
        }
        public static Gen GenRanGen(int min , int max , int gensize)
        {
            var sonuc = new Gen(gensize);
            
            for (int i = 0; i < sonuc.Genes.Length; i++)
            {

                sonuc.Genes[i] = RandomNumber(min, max);
            }
            return sonuc;
        }

        public static double solution(Gen a)
        {
            double sonuc = 0;
            for (int i = 0; i < 29; i++)
            {
                double son1 = a.Genes[i + 1] - Math.Pow(a.Genes[i], 2); // soldaki denk.
                son1 = Math.Pow(son1,2);
                son1 = 100 * son1;
                double son2 = a.Genes[i] - 1; //sağdaki denk
                son2 = Math.Pow(son2, 2);
                double son = son1 + son2;
                sonuc += son; //hepsinin toplamı x_1 = 1 de fon(x_1,x_2....,x_30) = 0 veriyor test ettim
            }

            return Math.Round(sonuc, Pop.penalty);
            
        }
        public static Pop Sort(Pop p)
        {
            IList<Gen> list = new List<Gen>();
            list = p.Kromozon;
            IEnumerable<Gen> sortedEnum = list.OrderBy(f => f.Score);
            IList<Gen> sortedList = sortedEnum.ToList();
            p.Kromozon = sortedList;
            return p;
        }
        
        public static Pop Capraz(Pop p , double sans) 
        {
            // 0 a en yakın olan yarısını eşleştirmede kullan Doğal seçim
            // Ağırlıklı eşleştirme metodu 5 kromozon eşleşcek
            bool anormal = false;
            Pop yen = new Pop(p.Kromozon.Count); //10 kromozon
            
            int sayi = p.Kromozon.Count; //10
            
                int esles = sayi / 2; //esles = 5 kromozon eslescek 
                if (esles % 2 == 1)// pop 5/2 odd ise yazı tura at 
                {
                    int yazıtura = random.Next(0, 2);
                    if (yazıtura == 0)//2 kromozon eşleştir kro[0,1,2,3]
                        esles--;
                    else // 5ciye eş bul kromozon[4]
                    {
                        esles--;
                        anormal = true;
                    }

                }
                esles = esles / 2;// 2 tane eşlestir
                int[] anne = new int[esles];
                int[] baba = new int[esles];
                int j = 0;
                for (j = 0; j < esles; j++) //0-1-2-3
                {
                    
                    double ran1 = RandomNumber(0, 1);
                    int a = 0;
                    for (; a < esles*2; ) //4
                    {
                        if (p.Kromozon[a].Kumdeg < ran1)
                        {
                            break;
                        }
                        else
                            a++;
                    }
                    anne[j] = a;
                    //p.Kromozon[a];
                    double ran2 = RandomNumber(0, 1);
                    int b = 0;
                    for (; b < esles*2; ) //4
                    {
                        if (p.Kromozon[b].Kumdeg < ran2)
                        {
                            break;
                        }
                        else
                            b++;
                    }
                    baba[j] = b;
                    
                    //p.Kromozon[b];
                    
                }
                

                for (int i = 0; i < esles; i++)  //Heuristik çaprazlama metoduyla extrapolasyon metodu
                {
                    double sanss = RandomNumber(0, 1);
                    if (sans > sanss) // 0.70 caprz oranı 
                    {

                        bool tersten = false;
                        int dongu = p.Kromozon[anne[i]].Genes.Length; //30 gen
                        Gen yen1 = new Gen(dongu);
                        Gen yen2 = new Gen(dongu);
                        int arasayı = random.Next(0, dongu); // nerden kesecegini ögren
                        int aradongu = arasayı;
                        if (arasayı == 0) // eğer ilk başsa sağdakilerini değiştir
                            aradongu = 1;
                        if (arasayı == dongu - 1) // eğer en sonsa soldakileri deiştir
                        {
                            aradongu = 0;
                            tersten = true; // en sondaki aynı kalsın
                        }

                        for (int l = 0; l < dongu; l++)
                        {
                            if (aradongu == l)
                            {
                                for (int k = aradongu; k < dongu; k++)
                                {
                                    double B = RandomNumber(0, 1);
                                    double a = p.Kromozon[anne[i]].Genes[k];
                                    double b = p.Kromozon[baba[i]].Genes[k];
                                    double sonuc = B * (a - b);
                                    yen1.Genes[k] = a - sonuc;
                                    yen2.Genes[k] = b - sonuc;
                                }


                                break;
                            }
                            else
                            {
                                yen1.Genes[l] = p.Kromozon[anne[i]].Genes[l];
                                yen2.Genes[l] = p.Kromozon[baba[i]].Genes[l];
                            }


                        }
                        if (tersten) // en sondakini aynı yap
                        {
                            yen1.Genes[dongu - 1] = p.Kromozon[anne[i]].Genes[dongu - 1];
                            yen2.Genes[dongu - 1] = p.Kromozon[baba[i]].Genes[dongu - 1];
                        }

                        yen.Kromozon.Add(yen1);
                        yen.Kromozon.Add(yen2);

                    }
                    else // olmazsa aySnı kalsın
                    {
                        yen.Kromozon.Add(p.Kromozon[anne[i]]);
                        yen.Kromozon.Add(p.Kromozon[baba[i]]);
                    }
                }
                if (anormal) // 5.ye eş bul 
                {
                    double sonsans = RandomNumber(0, 1);

                    int sones = esles * 2; // id si 4 yani kromozon[4]
                    Gen sonyen1 = new Gen(p.Kromozon[sones].Genes.Length);
                    Gen sonyen2 = new Gen(p.Kromozon[sones].Genes.Length);
                    int sonran = random.Next(0, esles);// 0 ile 3 arası bul
                    if (sans > sonsans) // 0.70 caprz oranı 
                    {

                        bool tersten = false;
                        int dongu = p.Kromozon[sones].Genes.Length;
                        int arasayı = random.Next(0, dongu); // nerden kesecegini ögren
                        int aradongu = arasayı;
                        if (arasayı == 0) // eğer ilk başsa sağdakilerini değiştir
                            aradongu = 1;
                        if (arasayı == dongu - 1) // eğer en sonsa soldakileri deiştir
                        {
                            aradongu = 0;
                            tersten = true; // en sondaki aynı kalsın
                        }

                        for (int l = 0; l < dongu; l++)
                        {
                            if (aradongu == l)
                            {
                                for (int k = aradongu; k < dongu; k++)
                                {
                                    double B = RandomNumber(0, 1);
                                    double a = p.Kromozon[sones].Genes[k];
                                    double b = p.Kromozon[sonran].Genes[k];
                                    double sonuc = B * (a - b);
                                    sonyen1.Genes[k] = a - sonuc;
                                    sonyen2.Genes[k] = b - sonuc;
                                }


                                break;
                            }
                            else
                            {
                                sonyen1.Genes[l] = p.Kromozon[sones].Genes[l];
                                sonyen2.Genes[l] = p.Kromozon[sonran].Genes[l];
                            }


                        }
                        if (tersten) // en sondakini aynı yap
                        {
                            sonyen1.Genes[dongu - 1] = p.Kromozon[sones].Genes[dongu - 1];
                            sonyen2.Genes[dongu - 1] = p.Kromozon[sonran].Genes[dongu - 1];
                        }

                        yen.Kromozon.Add(sonyen1);

                    }
                    else
                    {
                        yen.Kromozon.Add(p.Kromozon[sones]);
                    }

                }
                else
                {
                    yen.Kromozon.Add(p.Kromozon[sayi/2-1]);
                }
            for (int i = sayi/2; i < sayi; i++) // P kötü olanları ekliyoz
			{
                yen.Kromozon.Add(p.Kromozon[i]);
			}
            
            return yen;
        }
        public static Pop Mutasyon(Pop p, double sans)
        {
            
            
            foreach (Gen h in p.Kromozon)
            {
                for (int i = 0; i < h.Genes.Length; i++)
                {
                    double mut = RandomNumber(0, 1);
                    if (sans > mut)
                        h.Genes[i] = RandomNumber(-30, 30);
                }
                

            }

            return p;
        }
    }
}
