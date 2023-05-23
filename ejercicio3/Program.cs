//Ejercicio 3

int check(bool control, int number,int limInf, int limSup){
    while(number<limInf || number>limSup || control==false){
        Console.WriteLine("\nIngrese un valor indicado");
        control=int.TryParse(Console.ReadLine(),out number);
    }
    return number;
}

void numberData(float number){
    Console.WriteLine("\n----Datos del numero ingresado----");
    Console.WriteLine($"\nValor absoluto de {number.ToString()}: "+Math.Abs(number));
    Console.WriteLine($"\nPotencia cuadrada de {number.ToString()}: "+Math.Pow(number,2));
    Console.WriteLine($"\nRaiz cuadrada de {number.ToString()}: "+Math.Sqrt(number));
    Console.WriteLine($"\nSeno de {number.ToString()}: "+Math.Sin(number));
    Console.WriteLine($"\nCoseno de {number.ToString()} "+Math.Cos(number));
    Console.WriteLine($"\nParte entera: "+Math.Truncate(number));
}

int a,b,c,d=0;
float numE;
while(d==0){
    Console.WriteLine("----MENU----");
    Console.WriteLine("Que operacion desea realizar: \n 1=Suma \n 2=Resta \n 3=Dividir \n 4=Multiplicar \n 5=Saber los datos de algun numero");
    bool control=int.TryParse(Console.ReadLine(),out a);
    check(control,a,1,5);
    if(a!=5){
        Console.WriteLine("\nIngrese dos valores:");
        control=int.TryParse(Console.ReadLine(),out b);
        check(control,b,-10000,10000);
        control=int.TryParse(Console.ReadLine(),out c);
        check(control,c,-10000,10000);

        switch(a){
            case 1:
                Console.WriteLine($"\nSuma entre {b.ToString()} y {c.ToString()} es igual a {(b+c).ToString()}");
                break;
            case 2:
                Console.WriteLine($"\nResta entre {b.ToString()} y {c.ToString()} es igual a {(b-c).ToString()}");
                break;
            case 3:
                Console.WriteLine($"\nDivision entre {b.ToString()} y {c.ToString()} es igual a {(b/c).ToString()}");
                break;
            case 4:
                Console.WriteLine($"\nMultiplicacion entre {b.ToString()} y {c.ToString()} es igual a {(b*c).ToString()}");
                break;
        }
        Console.WriteLine($"\nEl maximo entre {b.ToString()} y {c.ToString()} es: {Math.MaxMagnitude(b,c).ToString()}");
        Console.WriteLine($"\nEl minimo entre {b.ToString()} y {c.ToString()} es: {Math.MinMagnitude(b,c).ToString()}");
    }
    if(a==5){
        Console.WriteLine("\nIngrese el numero del que desea saber sus datos:");
        numE=Console.Read();
        numberData(numE);
    }
    Console.WriteLine("\nDesea seguir operando en la calculadora?");
    Console.WriteLine("\n 0=SI\n 1=NO");
    control=int.TryParse(Console.ReadLine(),out d);
    check(control,d,0,1);
}