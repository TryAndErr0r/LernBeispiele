// See https://aka.ms/new-console-template for more information
using Beispiele;

//Beispiel 1
int kartoffel = 5;
BeispielKlasse.BeispielFunktion1(kartoffel);
Console.WriteLine($"Beispiel 1: {kartoffel}");


//Beispiel 2
IntWrapper intWrapper = new IntWrapper();
intWrapper.Moehre = 12;

BeispielKlasse.BeispielFunktion2(intWrapper);
Console.WriteLine($"Beispiel 2: {intWrapper.Moehre}");


//Beispiel 3 
BeispielKlasse.BeispielFunktion1(intWrapper.Moehre);
Console.WriteLine($"Beispiel 3: {intWrapper.Moehre}");

//Beispiel 4
BeispielKlasse.BeispielFunktion4(ref kartoffel);
Console.WriteLine($"Beispiel 4: {kartoffel}");

//Beispiel 5 
BeispielKlasse.BeispielFunktion5(kartoffel);
Console.WriteLine($"Beispiel 5: {kartoffel}");

//Beispiel 5.1 
kartoffel = BeispielKlasse.BeispielFunktion5(kartoffel);
Console.WriteLine($"Beispiel 5.1: {kartoffel}");

//Beispiel 6
BeispielKlasse.BeispielFunktion6( ref kartoffel);
Console.WriteLine($"Beispiel 6: {kartoffel}");