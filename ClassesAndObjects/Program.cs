using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new() { Name = "Car 1", EngineCapasity = 100};
            Console.WriteLine($"vehicle 1: {vehicle1}");
            vehicle1 = null;
            Vehicle vehicle2 = vehicle1 ?? new Vehicle("Car 2", 2000);

            Console.WriteLine($"vehicle 2: {vehicle2}");


            //Tworzenie obiektów

            //1.Napisz program, który utworzy obiekt klasy Osoba i przypisze wartości do jej pól imię, nazwisko, wiek.
            Person person = new Person("Derk", "Green", 25);
            //2.Utwórz klasę o nazwie prostokąt z polami szerokość i wysokość.Następnie utwórz obiekt i przypisz wartości do pól.
            Rectangle rectangle = new Rectangle(20.0, 40.0);
            //3.Utwórz klasę o nazwie student z polami nazwa, wiek, i stopień. Następnie utwórz obiekt klasy student i przypisz wartości do pól.
            Student student = new Student("Bob Tower", 24, "Bachelor's degree");
            //4.Utwórz klasę o nazwie pracownik z polami nazwa, wypłata i data zatrudnienia. Następnie utwórz obiekt klasy i przypisz wartości do pól.
            Employee employee = new Employee("Donald Tusk", 100000.50m, new DateTime(2008, 12, 10));
            //5.Utwórz klasę o nazwie konto bankowe z polami numer konta, stan i właściciel.Następnie utwórz obiekt
            //klasy i przypisz wartości do pól.
            BankAccount bankAccount = new BankAccount(123456, 150.96m, "Biden");
            //6.Utwórz klasę okrąg z polem promień.Następnie utwórz metody na obliczenie pola i obwodu koła oraz utwórz obiekt klasy
            //okrąg i przypisz wartość oraz przedstaw wynik pola i obwodu koła.
            Circle circle = new Circle(10);
            circle.CircleArea();
            circle.CircleCircumference();
            //7.Utwórz klasę kraj z polami nazwa oraz nazwa skrótowa. Dodaj metody na zmianę nazwy i nazwy skróty. Każda zmiana nazwy,
            //czy skrótu powinna zwrócić ten sam obiekt.Pola nazwa kraju i skrót powinny być dostępne tylko do odczytu.Utwórz metodę statyczną,
            //która będzie tworzyć taki obiekt Create. Każde tworzenie obiektu powinno odbywać się tylko za pomocą metody Create.
            Country country = Country.Create("Poland", "PL")
                .ChangeName("Germany");
        }
    }
}
