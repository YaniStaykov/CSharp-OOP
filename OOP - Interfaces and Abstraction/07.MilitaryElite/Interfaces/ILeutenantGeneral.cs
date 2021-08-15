namespace _07.MilitaryElite.Interfaces
{
    using _07.MilitaryElite.Models;
    using System.Collections.Generic;

    public interface ILeutenantGeneral
    {
        ICollection<Private> Privates { get; }
    }
}
