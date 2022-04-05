/*
Creación de un juego aleatorio
Vamos a inventarnos un juego que nos ayude a escribir instrucciones 
if. Crearemos varias reglas para el juego y, después, las 
implementaremos en el código.

Usaremos el método Random.Next() para simular que lanzamos 
tres dados de seis caras. Evaluaremos los valores para calcular 
la puntuación. Si la puntuación es mayor que un total arbitrario,
 el usuario verá un mensaje de que ha ganado. 
En caso contrario, el usuario verá un mensaje de que ha perdido.
1. Si dos dados cualesquiera muestran el mismo valor, se obtienen 
dos puntos extra por obtener un doble.
2. Si los tres dados muestran el mismo valor, se obtienen seis 
puntos extra por obtener un triple.
3. Si la suma de los tres dados, junto con los puntos extra, 
es igual o mayor que 15, gana el juego. De lo contrario, pierde.
*/
Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total = roll1+roll2+roll3;

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! + 6 bonus to total!");
    total +=6;
}
else
{
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! + 2 bonus to total!");
    total +=2;
}
}
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
