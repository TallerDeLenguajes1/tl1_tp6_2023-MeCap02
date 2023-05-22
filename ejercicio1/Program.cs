//Ejercicio 1
int a;
Console.WriteLine("Ingrese un valor");
bool control=int.TryParse(Console.ReadLine(),out a);
while(control==false){
    Console.WriteLine("Ingrese un valor correcto");
    control=int.TryParse(Console.ReadLine(),out a);
}
if(a>0){
    a=-a;
}
Console.WriteLine(a);
Console.WriteLine(control);