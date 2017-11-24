using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
    class Laborator
    {
        public Pristroj LaboratorniPristroj1; /*nove mozne typy premennej vytvarame preto sa calsam hovori typy*/
        public Pristroj LaboratorniPristroj2;

        public void SpustVyskum()
        {


            LaboratorniPristroj1 = new Mikroskop();
            LaboratorniPristroj2 = new Odstredivka();

            IOvladani ovladani = (IOvladani)LaboratorniPristroj1;
            ovladani.Zapni();

            LaboratorniPristroj1.VypisDetailniInfo();
            LaboratorniPristroj2.VypisDetailniInfo();
        }


    }
}
