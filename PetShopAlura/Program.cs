using PetShopAlura.Models;
using PetShopAlura.Services;

Dog dog1 = new("Ralph", "Golden Retriever", "BEM");
Dog dog2 = new("Bob", "Buldogue", "FERIDO");
Dog dog3 = new("Husky", "Husky Siberiano", "DOENTE");

OwnerPet own1 = new("Alan", dog1);
OwnerPet own2 = new("Bia", dog2);
OwnerPet own3 = new("Charles", dog3);

Veterinary dr = new("Darwin", dog1.PetHealthState);

Console.WriteLine(@"
██████╗░███████╗████████╗░██████╗██╗░░██╗░█████╗░██████╗░
██╔══██╗██╔════╝╚══██╔══╝██╔════╝██║░░██║██╔══██╗██╔══██╗
██████╔╝█████╗░░░░░██║░░░╚█████╗░███████║██║░░██║██████╔╝
██╔═══╝░██╔══╝░░░░░██║░░░░╚═══██╗██╔══██║██║░░██║██╔═══╝░
██║░░░░░███████╗░░░██║░░░██████╔╝██║░░██║╚█████╔╝██║░░░░░
╚═╝░░░░░╚══════╝░░░╚═╝░░░╚═════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░");
Console.WriteLine("\n\t\t\t\t\r████████████████████████████████\n\t\t\t\t\r██▀▄─██▄─▄███▄─██─▄█▄─▄▄▀██▀▄─██\n\t\t\t\t\r██─▀─███─██▀██─██─███─▄─▄██─▀─██\n\t\t\t\t\r▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀\n");
ConsultPetService ps = new();
ps.consultPet(dr, own1, dog1);
ps.consultPet(dr, own2, dog2);
ps.consultPet(dr, own3, dog3);
