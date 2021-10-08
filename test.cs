using System;

namespace test{
   class Computer{
       public double ramSize;
       public int cpuCount;

       public void GetInfo(){
       }
   }
   class Program{
     static void Main(string[] args){
         Computer comp1 = new Computer();
         comp1.cpu_count=2;
         comp1.ram_size=16;
     }
   }
}