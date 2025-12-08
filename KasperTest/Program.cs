// See https://aka.ms/new-console-template for more information
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;

// - Lavet af Kasper - 
//MEMBER REPOSITORY OG MEMBER KLASSEN
//-------------------------------------------------------------------------------------------------------------
#region Nye objekter af Member og MemberRepository skabes
Console.WriteLine("Nyt objekt af MemberRepository og Member skabes");
IMemberRepository memberRepo = new MemberRepository();
IMember member1 = new Member("Kasper", "Møller", "23456789", "Skovvej 111", "Næstved", "Kasper@hotmail.com", MemberType.Adult, MemberRole.Member);
#endregion
#region Count Property kaldes
Console.WriteLine("Kalder og printer Count property");
Console.WriteLine($"Antallet af Medlemmer er {memberRepo.Count}");
Console.WriteLine();
#endregion
#region AddMember metode
Console.WriteLine("Kalder AddMember metode på member1 og for den tilføjet til memberRepo");
memberRepo.AddMember(member1);
Console.WriteLine();
#endregion
#region Member klassens ToString metode
Console.WriteLine("Kalder Member klassens ToString for at printe member1 ud");
Console.WriteLine(member1.ToString());
Console.WriteLine();
#endregion
#region Kald af Count property igen
Console.WriteLine("Kalder og printer Count property efter tilføret member");
Console.WriteLine($"Antallet af Medlemmer er {memberRepo.Count}");
Console.WriteLine();
#endregion
#region UpdateMember metode
Console.WriteLine("Oprettet opdateret medlem med samme telefonnummer");
IMember updatedMember1 = new Member("Peter", "Jensen", "23456789", "Gedestien 10", "Ringsted", "PJ@gmail.com", MemberType.Senior, MemberRole.Member);

Console.WriteLine("Opdatere det nye medlem værdier ind i den oprindelige objektrefeence som er member1");
memberRepo.UpdateMember(updatedMember1);
Console.WriteLine();

Console.WriteLine("Printer den opdaterede member1 ud");
Console.WriteLine(member1.ToString());
Console.WriteLine();
#endregion
#region RemoveMember metode
Console.WriteLine("Kalder RemoveMember metoden og sletter objektet fra Repo");
memberRepo.RemoveMember(member1);
Console.WriteLine();
#endregion
#region Tilføjer 2 members, og tester GetAllMembers samt RemoveMember
Console.WriteLine("Tilføjer to nye medlemmer");
IMember member2 = new Member("Maria", "Strauss", "12123445", "Vej 34", "Glostrup", "Maria@gmail.com", MemberType.Adult, MemberRole.Admin);
IMember member3 = new Member("Frederik", "Carlsen", "34958272", "Fredevej 23", "Roskilde", "Frederik@gmail.com", MemberType.Adult, MemberRole.Member);
memberRepo.AddMember(member2);
memberRepo.AddMember(member3);

Console.WriteLine("Kalder GetAllMembers metoden og for printet dem ud på en liste i konsollen");
List<IMember> allmembers1 = memberRepo.GetAllMembers();
foreach(IMember m in allmembers1)
{
    Console.WriteLine(m.ToString());
}

Console.WriteLine("Kalder RemoveMember metoden og sletter objektet fra Repo");
memberRepo.RemoveMember(member1);
Console.WriteLine();


Console.WriteLine("Kalder GetAllMembers metoden og for printet dem ud på en liste i konsollen");
List<IMember> allmembers2 = memberRepo.GetAllMembers();
foreach (IMember m in allmembers2)
{
    Console.WriteLine(m.ToString());
}
#endregion
#region PrintAll Metode
Console.WriteLine();
memberRepo.PrintAll();
#endregion
#region Exception MemberPhoneNumberExistsException Test
try
{
    memberRepo.AddMember(new Member("Poul", "Henriksen", "11111111", "Roskildevej 2", "Roskilde", "roskilde@mail.dk", MemberType.Adult, MemberRole.Member));
    memberRepo.AddMember(new Member("Poul", "Henriksen", "11111111", "Roskildevej 2", "Roskilde", "roskilde@mail.dk", MemberType.Adult, MemberRole.Member));
}
catch (MemberPhoneNumberExistsException mex)
{
    Console.WriteLine(mex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
//-------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------