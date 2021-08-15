using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier
    {
        public enum Corps
        {
            Airforces,
            Marines
        }
        public interface ISpecialisedSoldier
        {
            Corps Corps { get; }
        }
    }
}
