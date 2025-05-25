using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class TerroristWeaponArssenal
    {
        private static readonly string[] allWeapon = new string[] { "knife", "gun", "M16", "AK47" };
        static Random rand = RandomProvider.GetRandom();
        public static string[] Personalweapon()
        {
            string[] Weapon = new string[rand.Next(1,allWeapon.Length+1)];
            for (int i = 0; i < Weapon.Length; i++)
            {
                string w = allWeapon[rand.Next(allWeapon.Length)];
                if (!Weapon.Contains(w))
                {
                    Weapon[i] = w;
                }
                else
                {
                    i--;
                }

            }
            return Weapon;
        }
    }
}
