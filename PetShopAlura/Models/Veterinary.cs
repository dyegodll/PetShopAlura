using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAlura.Models;

internal class Veterinary
{

    public string Name { get; set; }

    public string PetDiagnostic { get; set; }


    public Veterinary(string name, string petDiagnostic)
    {
        Name = name;
        PetDiagnostic = petDiagnostic;
    }


}
