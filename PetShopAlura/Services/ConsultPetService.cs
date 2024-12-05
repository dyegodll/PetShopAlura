using PetShopAlura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAlura.Services;

internal class ConsultPetService
{

    public Veterinary Veterinary { get; set; }
    public OwnerPet OwnerPet { get; set; }
    public Dog Dog { get; set; }


    public void consultPet(Veterinary vet, OwnerPet own, Pet pet)
    {
        Console.WriteLine($"\tO Dr. {vet.Name} está avaliando o Pet de {own.Name}, o {pet.Name}");
        Thread.Sleep(3000);
        Console.WriteLine($"O estado de Saúde de {pet.Name} é {pet.PetHealthState} no momento...");
        
        if (pet.PetHealthState.Equals("BEM"))
        {
            Console.WriteLine($"Nesse caso não precisa de tratamento... {pet.Name} está liberado.\nParabéns {own.Name} por cuidar tão bem do seu Pet!");
            vet.PetDiagnostic = "PET SAUDÁVEL";
        }
        if (pet.PetHealthState.Equals("DOENTE"))
        {
            Console.WriteLine($"Nesse caso é necessário tratamento, {pet.Name} irá receber as devidas medicações. \n{own.Name} traga {pet.Name} novamente em 8 dias para avaliarmos novamente!");
            vet.PetDiagnostic = "PET COM VIROSE";
        }
        if (pet.PetHealthState.Equals("FERIDO"))
        {
            Console.WriteLine($"Nesse caso é necessário tratamento, {pet.Name} irá receber as devidas medicações e curativos. \n{own.Name} traga {pet.Name} novamente em 8 dias para novas avaliações!");
            vet.PetDiagnostic = "PET COM LACERAÇÕES E HEMATOMAS";
        }

        Console.WriteLine($"O diagnóstico do Dr. {vet.Name} para o {pet.Name} é: {vet.PetDiagnostic}\n");
    }

    

}
