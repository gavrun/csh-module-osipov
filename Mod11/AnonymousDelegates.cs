//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousDelegate_Sample
{

    // Define the delegate method.
    delegate decimal CalculateBonus(decimal sales);

    // Define an Employee type.
    class Employee
    {
        public string Name { get; set; }
        public decimal Sales { get; set; }
        public decimal Bonus { get; set; }
        public CalculateBonus CalculationAlgorithm { get; set; }
    }

    class Program
    {

        // This class will define two delegates that perform a calculation.
        // The first will be a named method, the second an anonymous delegate.

        // This is the named method.
        // It defines one possible implementation of the Bonus Calculation algorithm.

        static decimal CalculateStandardBonus(decimal sales)
        {
            return sales / 10;
        }

        static void Main(string[] args)
        {

            // A value used in the calculation of the bonus.
            // Note: This local variable will become a "captured outer variable".
            decimal multiplier = 2;

            // This delegate is defined as a named method.
            CalculateBonus standard_bonus = new CalculateBonus(CalculateStandardBonus);

            // This delegate is anonymous - there is no named method.
            // It defines an alternative bonus calculation algorithm.
            CalculateBonus enhanced_bonus = delegate(decimal sales) { return multiplier * sales / 10; };

            // Declare some Employee objects.
            Employee[] staff = new Employee[5];

            // Populate the array of Employees.
            for (int i = 0; i < 5; i++)
                staff[i] = new Employee();

            // Assign initial values to Employees.
            staff[0].Name = "Mr Apple";
            staff[0].Sales = 100;
            staff[0].CalculationAlgorithm = standard_bonus;

            staff[1].Name = "Ms Banana";
            staff[1].Sales = 200;
            staff[1].CalculationAlgorithm = standard_bonus;

            staff[2].Name = "Mr Cherry";
            staff[2].Sales = 300;
            staff[2].CalculationAlgorithm = standard_bonus;

            staff[3].Name = "Mr Date";
            staff[3].Sales = 100;
            staff[3].CalculationAlgorithm = enhanced_bonus;

            staff[4].Name = "Ms Elderberry";
            staff[4].Sales = 250;
            staff[4].CalculationAlgorithm = enhanced_bonus;

            // Calculate bonus for all Employees
            foreach (Employee person in staff)
                PerformBonusCalculation(person);

            // Display the details of all Employees
            foreach (Employee person in staff)
                DisplayPersonDetails(person);


        }

        public static void PerformBonusCalculation(Employee person)
        {

            // This method uses the delegate stored in the person object
            // to perform the calculation.
            // Note: This method knows about the multiplier local variable, even though
            // that variable is outside the scope of this method.
            // The multipler varaible is a "captured outer variable".
            person.Bonus = person.CalculationAlgorithm(person.Sales);
        }

        public static void DisplayPersonDetails(Employee person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Bonus);
            Console.WriteLine("---------------");
        }
    }
}


