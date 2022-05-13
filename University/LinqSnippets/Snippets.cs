using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LinqSnippets
{

    public class Snippets
    {
        static public void BasicLinQ()
        {

                string[] cars =
            {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat Leon"
            };

            // 1. Select * de toda la lista de coches
            var carList = from car in cars select car;
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

            // 2. Select Where seleccionar uno en especifico
            var audiList = from car in cars where car.Contains("Audi") select car;
            foreach(var audi in audiList)
            {
                Console.WriteLine(audi);
            }
           
        }

        // Ejemplos con numeros
        static public void LinqNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // cada numero multiplicado por
            // todos los mumeros menos el 9
            // Ordenamos de manera ascendente

            var processedNumberList = numbers
                .Select(num => num * 3) 
                .Where(num => num != 9)
                .OrderBy(num => num);
        } 
        static public void SearchExamples()
        {
            List<string> textList = new List<string>
            {
                "a",
                "bx",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "cj",
                "c"
            };
            // encontar el primer elemento
            var first = textList.First();

            // 2. primer elemento que sea c
            var cText = textList.First(text => text.Equals("c"));

            // 3. cojer un elemento que contenga una palabra
            var jText = textList.First(text => text.Contains("j"));

            // 4. primer elemento que contenga la z y si no coje un valor por defecto
            var firstOrDefaultText = textList.FirstOrDefault(text => text.Contains("z"));
        
            // 5. o el ultimo elemento o el valor por defecto
            var lastOrDefaultText = textList.LastOrDefault(text => text.Contains("z"));

            // 6. valor unico eivta los elementos repetidos
            var uniqueText = textList.Single();
            var uniqueorDefaultText = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherEvenNumbers = { 0, 2, 6 };

            // obtener el 4 y el 9 no se estan repitiendo
            var myEvenNumbers = evenNumbers.Except(otherEvenNumbers);

        }

        static public void MultipleSelect()
        {
            // Select many
            string[] myOpinions =
            {
                "Opinion 1, Text 1",
                "Opinion 2, Text 2",
                "Opinion 3, Text 3",
                "Opinion 4, Text 4"
            };
            var myOpinionSelection = myOpinions.SelectMany(opinion => opinion.Split(","));

            var Enterprises = new[]
            {
                new Enterprise()
                {
                    Id =    1,
                    Name = "Enterprise 1",
                    Employees = new[]
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Martin",
                            Email = "martin@imaginero.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Pepe",
                            Email = "martin@imaginero.com",
                            Salary = 1000
                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Juanjo",
                            Email = "juando@imaginero.com",
                            Salary = 2000
                        }
                    }
                 },
                new Enterprise()
                {
                    Id =   2,
                    Name = "Enterprise 2",
                    Employees = new[]
                    {
                        new Employee
                        {
                            Id = 4,
                            Name = "Ana",
                            Email = "ana@imaginero.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "Maria",
                            Email = "maria@imaginero.com",
                            Salary = 1500
                        },
                        new Employee
                        {
                            Id = 6,
                            Name = "Marta",
                            Email = "marta@imaginero.com",
                            Salary = 2000
                        }
                    }
                 }

            };
            
            // obtener todos los empleados de todas las empresas
            var employeeList = Enterprises.SelectMany(enterprise => enterprise.Employees)

        }
       

    }
}