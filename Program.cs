/*
//Ejercicio 1
//Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje.
//Ej: nombre, apellido, edad, sabe programar, etc.
Console.WriteLine("Digite su nombre: ");
string nombre=Console.ReadLine();
Console.WriteLine("Digite su apellido: ");
string apellido=Console.ReadLine();
Console.WriteLine("Digite su edad: ");
int edad= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su estatura: ");
float estatura= float.Parse(Console.ReadLine());
Console.WriteLine("Quiere trabjar como programador en ? : ");
string programador=Console.ReadLine();
Console.WriteLine("Digite cuanto aspira ganar como trabajador de : ");
double salario= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hola, " + nombre +" " + apellido + ", tienes : " + edad + " años , mides: " + estatura );
Console.WriteLine("tu sueño es  trabajar como  programador de  : " + programador + " y ganar: " + salario );
*/


//Ejercicio2
//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: puertas, ruedas, marca, ITV vigente
//Mesa: peso, largo, material, color
//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.


//Coche
/*
Console.WriteLine("Cuantas puertas tiene su coche? ");
int puertas= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cual es la circurferencia en metros de tus ruedas? ");
string ruedas= Console.ReadLine();
Console.WriteLine("Que marca es tu carro? ");
string marca=Console.ReadLine();
Console.WriteLine("Hasta que año tienes el ITV vigente");
int ITV=Convert.ToInt32(Console.ReadLine());
var coche = " usted tiene un coche ,el cual tiene  " + puertas + " puertas " + " , sus ruedas tienen una circunferencia de "  + ruedas + " metros, es de marca " + marca + " , con vigencia del ITV hasta el año  " + ITV;
Console.WriteLine(coche1);
*/



//Mesa
/*
Console.WriteLine("Cuantas kg pesa su mesa ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("cuanto  cm mide de largo su mesa? ");
float Largo = float.Parse(Console.ReadLine());
Console.WriteLine("De que material esta echa tu mesa? ");
string material = Console.ReadLine();
Console.WriteLine("De que color es tu mesa");
string color = (Console.ReadLine());
var mesa = "usted tiene una mesa que pesa " + peso + " kg, mide de largo " + Largo + " cm, esta fabricada con un material llamado " + material + " y es de color " + color;
Console.WriteLine(mesa);
*/

/*
//Ejercicio 3
//Un número es mayor o igual a 18
int a = 25;
int b = 18;
Console.WriteLine(25 >= b);
Console.WriteLine(b >= 18);


//Un char es ‘a’
char c = 'a';
char d = 'A';
Console.WriteLine(c == d);
Console.WriteLine(c == char.ToLower(d));


int e = 9;
int f = 11;

//Se cumplen dos conciones a la vez (ambas verdaderas)
Console.WriteLine(e < 10 && f >= 11);

//Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine(e < 10 || f >= 11); 
*/