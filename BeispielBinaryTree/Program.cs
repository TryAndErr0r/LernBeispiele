// See https://aka.ms/new-console-template for more information

using BeispielBinaryTree;


//Aufgabe 1 
var zuFindenden = new BaumElement(5, null, null);
BaumElement tree = new BaumElement(
    8
    , new BaumElement(
        6,
        zuFindenden,
        new BaumElement(7, null, null)),
    new BaumElement(15, null, null));

if(tree.Finde(5) == zuFindenden)
{
    Console.WriteLine("YEY");
}
else
{
    Console.WriteLine("NEY");
}


