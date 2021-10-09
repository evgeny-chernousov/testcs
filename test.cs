using System;

namespace test{
   public class Computer{
        public string make;
        private int cpuCount;
        private double ramSize;
        public Computer(string make, int cpuCount, double ramSize){
            this.make = make;
            this.cpuCount = cpuCount;
            this.ramSize = ramSize;
        }

        public double RamSize{
           get{
               return ramSize;
           }
           set{
               if (value < 0){
                   ramSize = 0;
               }
               else{
                   ramSize = value;
               }
           }
       }
        public int CpuCount{
           get{
               return cpuCount;
           }
           set{
               if (value < 0){
                   cpuCount = 0;
               }
               else{
                   cpuCount = value;
               }
           }
       }

       

        public void GetInfo(){
            Console.WriteLine("The computer " + this.make + " has " + this.ramSize + " GB RAM amd " + this.cpuCount + " CPU cores"  );
        }

   }


   class Program{
     static void Main(string[] args){
         
         Computer comp1 = new Computer("Mac", "4", "8");
         


         //comp1.make = "Mac";
         //comp1.CpuCount = -2;
         //comp1.RamSize = 16;

         Console.WriteLine(comp1.RamSize);

         comp1.GetInfo();
     }
   }
}