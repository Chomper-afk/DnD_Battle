using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Stat {

        public int Base { get {
                if (Base_P + Change < Minimum) return Minimum;
                if(Base_P + Change >= Minimum) return Base_P + Change;
                if (Base_P + Change < Maximum) return Base_P + Change;
                if (Base_P + Change >= Maximum) return Maximum;
                return 0;
            } set { Base_P = value; } }
        public int Modifier { get { return (Base - 10) / 2; } }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Change {  get; set; }


        public Stat(int _Base, int _Min = 0, int _Max = 100) {
            Base = _Base;
            Minimum = _Min;
            Maximum = _Max;
        }

        private int Base_P;
    }
}
