using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private string _name;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string name, int fødselsmåned, int fødselsdag)
        {
            _name = name;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }
        
        public string Name { get; }

        public int Fødselsmåned { get; }

        public int Fødselsdag { get; }

    }
}
