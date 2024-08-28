using System.Collections.Generic;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class Features
    {
        public List<string> AllFeatures { set; get; }
    }

    public class Cfg1
    {
        private static Cfg1 instance = null;

        private Cfg1()
        {
        }

        public static Cfg1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cfg1();
                }
                return instance;
            }
        }

        public List<Features> Table { set; get; } = new List<Features>();

        public void InitializeA()
        {
            Features f0 = new Features() { AllFeatures = new List<string>() { "RH0", "00", "01" } };
            Features f1 = new Features() { AllFeatures = new List<string>() { "RH1", "10", "11" } };

            Table.Clear();

            Table.Add(f0);
            Table.Add(f1);
        }
        
        public void InitializeB()
        {
            Features f0 = new Features() { AllFeatures = new List<string>() { "RH0", "00", "01", "03" } };
            Features f1 = new Features() { AllFeatures = new List<string>() { "RH1", "10", "11", "13" } };
            Features f2 = new Features() { AllFeatures = new List<string>() { "RH2", "20", "21", "23" } };

            Table.Clear();

            Table.Add(f0);
            Table.Add(f1);
            Table.Add(f2);
        }
    }
}
