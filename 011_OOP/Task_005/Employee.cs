using System;

namespace Task_005
{
    class Employee
    {
        private readonly string firstName = null;
        private readonly string secondName = null;
        public double standartSalary { set; get; } = 10000;
        public double fullSalary { set; get; }
        public double positionCoef { set; get; }
        public double Fee { set; get; }
     

        public Employee(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public void EmployeeSalary(string position, int yearsExp)
        {
            if (position == "director" || position == "Director")
            {
                if (yearsExp >= 1 && yearsExp < 5)
                {
                    Fee = 0.15;
                    positionCoef = 10.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }

                else if (yearsExp >= 5 && yearsExp < 10)
                {
                    Fee = 0.25;
                    positionCoef = 13.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }
                else if (yearsExp >= 10)
                {
                    Fee = 0.35;
                    positionCoef = 18.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }
            }

            else if (position == "Administrator" || position == "administrator")
            {
                if (yearsExp >= 1 && yearsExp < 5)
                {
                    Fee = 0.15;
                    positionCoef = 5.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }

                else if (yearsExp >= 5 && yearsExp < 10)
                {
                    Fee = 0.25;
                    positionCoef = 6.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }
                else if (yearsExp >= 10)
                {
                    Fee = 0.35;
                    positionCoef = 7.25;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }                
            }
            else if (position == "Worker" || position == "worker")
            {
                if (yearsExp >= 1 && yearsExp < 5)
                {
                    Fee = 0.15;
                    positionCoef = 3.5;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }

                else if (yearsExp >= 5 && yearsExp < 10)
                {
                    Fee = 0.25;
                    positionCoef = 4.5;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }
                else if (yearsExp >= 10)
                {
                    Fee = 0.35;
                    positionCoef = 5.5;
                    fullSalary = standartSalary * Fee * positionCoef;
                    Console.WriteLine($"{position} - {firstName} {secondName} Standart salary = {standartSalary}");
                    Console.WriteLine($"Full Salary = {fullSalary}, Fee - {Fee} and PositionCoef {positionCoef}");
                }
            }
        }


    }
}
