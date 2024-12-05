using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAlura.Models;

public abstract class Pet
{

    public string Name { get; set; }
    public string PetBreed { get; set; }
    public string PetHealthState { get; set; }

    protected Pet(string name, string petBreed, string petHealthState)
    {
        Name = name;
        PetBreed = petBreed;
        PetHealthState = petHealthState;
    }

}
