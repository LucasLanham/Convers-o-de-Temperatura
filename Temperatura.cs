/ Declarando as variáveis com double
        double FahrenheitOriginal1;
double Celsius1;
double FahrenheitFinal1;

// Calcular Fahrenheit = 0
FahrenheitOriginal1 = 120;
print("Fahrenheit Original1: " + FahrenheitOriginal1);
Celsius1 = (FahrenheitOriginal1 - 32) / 9 * 5;
print("Celsius1: " + Celsius1);
FahrenheitFinal1 = (Celsius1 * 9) / 5 + 32;
print("Fahrenheit Final1: " + FahrenheitFinal1);

if (Celsius1 >= 30)
{ print("A estação do ano é o verão"); }
else if (Celsius1 >= 23)
{ print("A estação do ano é o primavera"); }
else if (Celsius1 >= 15)
{ print("A estação do ano é o outono"); }
else
{ print("A estação do ano é o inverno"); }

// Declarando as variáveis com int
int FahrenheitOriginal2;
int Celsius2;
int FahrenheitFinal2;

// Calcular Fahrenheit = 0
FahrenheitOriginal2 = 10;
print("Fahrenheit Original2: " + FahrenheitOriginal2);
Celsius2 = (FahrenheitOriginal2 - 32) / 9 * 5;
print("Celsius2: " + Celsius2);
FahrenheitFinal2 = (Celsius2 * 9) / 5 + 32;
print("Fahrenheit Final2: " + FahrenheitFinal2);

if (Celsius2 >= 30)
{ print("A estação do ano é o verão"); }
else if (Celsius2 >= 23)
{ print("A estação do ano é o primavera"); }
else if (Celsius2 >= 15)
{ print("A estação do ano é o outono"); }
else
{ print("A estação do ano é o inverno"); }