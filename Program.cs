using System;
using System.Collections;
using System.Numerics;

//Program validates the dc circuit by finding voltage given current and resistance

namespace dccircuit
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circuit ckt = new Circuit();
            
            Console.WriteLine("Enter current as an int:");
            int amp = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter resistance: ");
            int resist = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter resistance: ");
            int resist1 = Convert.ToInt32(Console.ReadLine());

            int volt = ckt.getVolt(amp, resist, resist1);
            Console.WriteLine("the voltage is: " + volt);
        }
    }
    class Resistor
    {
        int resistance;
        string name;
        public int Resistance { get; set; }
        public Resistor(string nm, int rs)
        {
            name = nm;
            resistance = rs;
        }
        public Resistor()
        {

        }
    }
    class Volt
    {
        int volt;
        public int Voltage { get; set; }
        public Volt(int vl)
        {
            volt = vl;
        }

        public Volt()
        {
        }
    }
    class Current
    {
        double amp;
        public int Amphere { get; set; }
        public Current (int ct)
        {
            amp = ct;
        }
        public Current()
        {

        }
    }
    class Circuit
    {
        Volt v1 = new Volt(6);
        Current q1 = new Current(12);
        Resistor r1 = new Resistor("r1", 100);
        Resistor r2 = new Resistor("r2", 200);
        public Circuit(Volt vt1, Current ct, Resistor res, Resistor res2)
        {
            v1 = vt1;
            q1 = ct;
            r1 = res;
            r2 = res2;

        }
        public Circuit()
        {

        }
        //ArrayList res = new ArrayList();

        public int getVolt(int ct, int res1, int res2)
        {
            int voltage;
            

            Resistor resist1 = new Resistor();
            resist1.Resistance = res1;
            Resistor resist2 = new Resistor();
            resist1.Resistance = res2;
           

            voltage = ct * (res1 + res2);
            return voltage;
        }
    }
}