using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    public class Stat {

        public int Base { get {
                if (Base_P + Change < Minimum) return Minimum;
                if (Base_P + Change >= Maximum) return Maximum;
                if(Base_P + Change >= Minimum) return Base_P + Change;
                return 0;
            } set { Base_P = value; } }
        public int Modifier { get { return (Base - 10) / 2; } }
        public int Minimum => Min();
        public int Maximum => Max();
        public int Change => Changeing();

        private Func<int> Min;
        private Func<int> Max;
        private Func<int> Changeing;


        public Stat(int _Base, Func<int> _Min, Func<int> _Max, Func<int> _Changing) {
            Base = _Base;
            Min = _Min;
            Max = _Max;
            Changeing = _Changing;
        }

        private int Base_P;
    }
}
