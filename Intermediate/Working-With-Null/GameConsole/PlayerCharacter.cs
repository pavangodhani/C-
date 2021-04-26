using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        private ISpecialDefence _specialDefence;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            // int damageReduction = 0;

            // if (_specialDefence != null)
            // {
            //     damageReduction = _specialDefence.CalCulateDemageReduction(damage);
            // }
    
            // int totalDemageTaken = damage - damageReduction;

            int totalDemageTaken = damage - _specialDefence.CalCulateDemageReduction(damage);

            Health -= totalDemageTaken;

            System.Console.WriteLine($"{Name}'s health has been reduced by {totalDemageTaken} to {Health} ");
        }




        // public Nullable<int> DaysSinceLastLogin { get; set; }
        // public DateTime? DateOfBirth { get; set; } //its a short cut of create a nullable<datetime>
        // public bool? IsNoob { get; set; }
    }

}