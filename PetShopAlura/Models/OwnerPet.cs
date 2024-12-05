using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAlura.Models;

internal class OwnerPet
{

    public string Name { get; set; }
    public Pet Pet{ get; set; }
    
    public OwnerPet(string name, Pet pet)
    {
        Name = name;
        Pet = pet;
    }
}
