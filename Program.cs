
// Challenge 3

List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
foreach (int i in MoreNumbers)
{
    // El error es que se usa el contenido (i) en vez de el index de la lista por lo tanto siempre va a dar una excepcion.
    // Console.WriteLine(MoreNumbers[i]);
    // por lo tanto para que se imprima el contenido correctamente deberia usarse directamente la variable i para imprimir el contenido.
    // Pd. El nombre no es descriptivo, ya que uno puede inferir que es un iterador o index.
    Console.WriteLine(i);
}

// Challenge 4

List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
/*
foreach(int num in EvenMoreNumbers)
{

    if(num % 3 == 0)
    {
        // De partida el foreach no permite modificar el valor iterable (num) por ser solo lectura
        // De segunda creo que el código quiere dejar en 0 los valores de la lista  EvenMoreNumbers en vez de cambiar el valor del iterable
        // num = 0;
        // Por lo cual se debe cambiar la estructura completa del foreach
    }
}
*/

for (int index = 0; index < EvenMoreNumbers.Count; index++)
{
    if (EvenMoreNumbers[index] % 3 == 0)
    {
        EvenMoreNumbers[index] = 0;
    }
}

// Challenge 5
// What can we learn from this error message?

string MyString = "superduberawesome";
// 0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16
// s  u  p  e  r  d  u  b  e  r  a  w  e  s  o  m  e

// Los string en c# son inmutables por lo que se debe re construir un string si quisiéramos cambiar un valor en especifico
// MyString[7] = "p";
// Por lo tanto usamos substring para recorrer y traer del 0 a la posicion 7 (los arreglos comienzan en 0 en C#) y le añadimos el valor que se requiere modificar
// para posteriormente concatenar el resto de el string

MyString = MyString.Substring(0, 7) + "p" + MyString.Substring(8);


// Challenge 6
// Hint: some bugs don't come with error messages

Random rand = new Random();

// Mas que error el tema es que el if no siempre va cumplirse, ya que el rand.next(12) 
// dice que hasta el numero 12 puede llegar pero comienza desde el 0 al 12 y el if solo cubre el 12. 
// (Esto es por la definición básica, para especificar un mínimo y un maximo se debe añadir el min y el max a la función next)
// Un parche temporal que se podría añadir seria usar un else para ver que numero salió pero no se cual seria el uso del if en cuestión.

int randomNum = rand.Next(12);
if (randomNum == 12)
{
    Console.WriteLine("Hello");
}