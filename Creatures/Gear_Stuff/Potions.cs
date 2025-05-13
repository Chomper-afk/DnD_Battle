using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Creatures.Gear_Stuff {
    internal class Potions : AItems {

        public Potions(string name, string description, int amount = 1, int action = 1, Effect? effect = null) {
            Name = name;
            Description = description;
            Amount = amount;
            Type = "Potion";
            Action = action;
            Effect = effect;
        }

        public override string Name { get; set;}
        public override string Description { get; set;}
        public override int Amount { get; set;}
        public override string Type { get; set;}
        public override int Action { get; set;}
        public Effect? Effect { get; set;}
        public override void Use_Other(ACreature User, ACreature Target) {
            if (!(Action == 1 && Settings.Actions <= 0 || Action == 2 && Settings.B_Actions <= 0)) {
                Amount--;
                switch (Action) {
                    case 1:
                        Settings.Actions--;
                        break;
                    case 2:
                        Settings.B_Actions--;
                        break;
                }
                if (Dice.Rolling(20, 1) + User.DEX.Modifier >= Target.AC) {
                    if(Effect != null) {
                        Effect temp = new Effect(Effect);
                        Target.Effects.Add(temp);
                        Target.Effect_Decay(temp);
                    }

                }
            }
            else MessageBox.Show("No action/bonus action");
        }

        public override void Use_Sefl(ACreature User) {
            if (!(Action == 1 && Settings.Actions <= 0 || Action == 2 && Settings.B_Actions <= 0)) {
                switch (Action) {
                    case 1:
                        Settings.Actions--;
                        break;
                    case 2:
                        Settings.B_Actions--;
                        break;
                }
                Amount--;
                if (Effect != null) {
                    Effect temp = new Effect(Effect);
                    User.Effects.Add(temp);
                    User.Effect_Decay(temp);
                }

            }
            else MessageBox.Show("No action/bonus action");
        }

        public override void Use_Special(ACreature User) {
            throw new NotImplementedException();
        }
    }
}
