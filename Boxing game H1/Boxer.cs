using Boxing_game_H1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxinggame
{
    public class Boxer
    {
        string _name;
        int _currenthealth;
        int _maxhealth;
        int _healchance;
        int _heal;
        int _damage;
        int _healMin;
        int _healMax;


        Random rnd;

        public Boxer()
        {
            _name = Name;
            _maxhealth = 100;
            _currenthealth = _maxhealth;
            _healchance = 5;
            _heal = 10;
            _damage = 10;
            rnd = new Random();
        }
        //public int Damage { get; set; }

        public void Attack(Boxer D)
        {
            D.CurrentHealth = D.CurrentHealth - Damage;

            if (D.CurrentHealth <= 0)
            {

            }
        }

        public void TryHeal()
        {

            if (rnd.Next(10) < HealChance)
            {
                //int heal = _random.Next(_healMin,_healMax);
                
                CurrentHealth += _heal;

                Console.WriteLine($"healed {Name} for {_heal}");
            }
            else
            {
                Console.WriteLine(Name + " Did not heal this time");

            }
        }
        //public int DoDamage()
        //{
        //    int damage = _random.Next(10, 25);

        //    return damage;
        //}
        public int CurrentHealth
        {
            get { return _currenthealth; }
            set { _currenthealth = Math.Max(0, value); }
        }

        public int Damage { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HealChance
        {
            get { return _healchance; }
            set { _healchance = value; }
        }


    }
}
