using _07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral
    {
        ICollection<Private> Privates { get; }
    }
}
