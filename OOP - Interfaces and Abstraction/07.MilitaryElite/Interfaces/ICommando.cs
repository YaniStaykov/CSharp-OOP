namespace _07.MilitaryElite.Interfaces
{
    using _07.MilitaryElite.Models;
    using System.Collections.Generic;

    public interface ICommando
    {
        ICollection<Mission> Missions { get; } 
    }
}
