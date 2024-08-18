namespace Enumerators_iterators_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Employye em1 = new Employye { ID = 123 , Name = "rachid el Maakoul", Salary = 1000m , Department = "IT"};
          Employye em2 = new Employye { ID = 123 , Name = "rachid el Maakoul", Salary = 1000m , Department = "IT"};


            Console.WriteLine(em1 == em2);
            Console.WriteLine(em1.Equals(em2));
            Console.ReadLine();
        }
    }
    public class Employye
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        //Override Equals()
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employye))
                return false;


            var emp = obj as Employye;
            return this.ID == emp.ID
                   && this.Name == emp.Name
                   && this.Salary == emp.Salary
                   && this.Department == emp.Department;
        }


        // Another Methode For Equals()
        public static bool operator ==(Employye lho, Employye rho) => lho.Equals(rho);
        public static bool operator !=(Employye lho, Employye rho) => !(lho.Equals(rho));

        //Override GetHashCode()
        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 23 + ID.GetHashCode();
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Salary.GetHashCode();
            hash = hash * 23 + Department.GetHashCode();
            return hash;
        }

        //method 
        //public static bool operator ==(Employye obj , Employye rho)
        //{
        //    var valueId = obj.ID == rho.ID;
        //    var valueName = obj.Name == rho.Name;
        //    var valueSalary = obj.Salary == rho.Salary;
        //    var valueDepartment = obj.department == rho.department;
        //    return (valueId && valueName && valueSalary && valueDepartment);
        //}
        //public static bool operator !=(Employye obj
        //    , Employye rho)
        //{
        //    var valueId = obj.ID != rho.ID;
        //    var valueName = obj.Name != rho.Name;
        //    var valueSalary = obj.Salary != rho.Salary;
        //    var valueDepartment = obj.department != rho.department;
        //    return !(valueId && valueName && valueSalary && valueDepartment);
        //}


    }
}
