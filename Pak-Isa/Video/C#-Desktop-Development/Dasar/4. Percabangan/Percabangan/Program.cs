// IF
int umur = 15;

//if (umur >= 17)
//{
//    Console.WriteLine("Boleh membuat KTP");
//}


// ELSE
if (umur >= 17)
{
    Console.WriteLine("Boleh membuat KTP");
}
else
{
    Console.WriteLine("Belum boleh membuat KTP");
}


// ELSE IF
int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}


// SWITCH

string hari = "Minggu";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari Pertama");
        break;

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default:
        Console.WriteLine("Hari lain");
        break;
}
