using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class Pickaxe : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public Pickaxe()
        {
            //ustalamy nazwe itemu
            name = "Pickaxe";
            // jego cene
            price = 875;
            //i atrybuty
            AddStat(Stat.AD, 25);
        }
    }
}