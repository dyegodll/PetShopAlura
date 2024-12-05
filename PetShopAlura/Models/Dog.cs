using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetShopAlura.Models;

internal class Dog : Pet
{
    public Dog(string name, string petBreed, string petHealthState) : base( name, petBreed, petHealthState) { }

}
