using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Map_stuff {
    internal class Tyle {
        public string Name { get; set; }
        public float Move_Factor {  get; set; }
        public DMG Enter_DMG { get; set; }
        public DMG Move_DMG { get; set; }
        public Color Tyle_Color {  get; set; }


        public Tyle(String _Name,int _Alpha, int _Red, int _Green, int _Blue, float _Move_Factor = 1, DMG? _Enter_DMG = null, DMG? _Move_DMG = null) {
            Tyle_Color = Color.FromArgb(_Alpha, _Red, _Green, _Blue);
            Name = _Name;
            Move_Factor = _Move_Factor;
            Enter_DMG = _Enter_DMG ?? new DMG();
            Move_DMG = _Enter_DMG ?? new DMG();
        }
    }
}
