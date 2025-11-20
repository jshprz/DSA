namespace AdvanceMethodsUsage
{
    public class DictionaryPractice
    {
        public Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
        {
            var employeesDepartments = new Dictionary<string, List<Employee>>();

            foreach (var employee in employees)
            {
                if (!employeesDepartments.ContainsKey(employee.Department))
                {
                    employeesDepartments[employee.Department] = new List<Employee>();
                }

                employeesDepartments[employee.Department].Add(employee);
            }

            var result = new Dictionary<string, decimal>();

            foreach (var employeesDepartment in employeesDepartments)
            {
                decimal sumOfSalaries = 0;

                foreach (var employee in employeesDepartment.Value)
                {
                    sumOfSalaries += employee.MonthlySalary;
                }

                var average = sumOfSalaries / employeesDepartment.Value.Count;

                result[employeesDepartment.Key] = average;
            }

            return result;
        }

        public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
        {
            var petsTypes = new Dictionary<PetType, List<double>>();

            foreach (var pet in pets)
            {
                if (!petsTypes.ContainsKey(pet.PetType))
                {
                    petsTypes[pet.PetType] = new List<double>();
                }

                petsTypes[pet.PetType].Add(pet.Weight);
            }

            var result = new Dictionary<PetType, double>();

            foreach (var petsType in petsTypes)
            {
                result[petsType.Key] = petsType.Value.Max();
            }

            return result;
        }
    }

    public class Employee
    {
        public string Name { get; init; }
        public string Department { get; init; }
        public decimal MonthlySalary { get; set; }

        public Employee(string name, string department, decimal monthlySalary)
        {
            Name = name;
            Department = department;
            MonthlySalary = monthlySalary;
        }
    }

    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }

    public enum PetType { Dog, Cat, Fish }
}
