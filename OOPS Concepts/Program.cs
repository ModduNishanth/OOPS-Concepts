                                                         // OOPS Concepts//

                                                      // Single Inheritance//
//public class Employee
//{
//    public int salary = 40000;
//}
//public class Programmer : Employee
//{
//    public int bonus = 10000;
//}
//class TestSalary
//{
//    public static void Main(string[] args)
//    {
//        Programmer p1 = new Programmer();

//        Console.WriteLine("Salary: " + p1.salary);
//        Console.WriteLine("Bonus: " + p1.bonus);

//    }
//}





                                                          // Multiple Inheritance//


//public class Banking
//{
//    private string BankName;
//    public string AccountName
//    {
//        get
//        {
//            return AccountName;
//        }
//        set
//        {
//            AccountName = value;
//        }
//    }
//}
//public class Bank
//{
//    public static int Main(string[] args)
//    {
//        Banking d = new Banking();
//        d.AccountName = "HDFC Bank";
//        Console.WriteLine("The Bank is : " + d.AccountName);
//        return 0;
//    }
//}



                                                         //Hierarchical Inheritance//



//class Kalpita
//{
//    public string CompanyName = "Kalpita Technologies";
//    public string CompanyType = "Software Industry";
//    public int CompanyID = 062345;
//}
//class Employee : Kalpita
//{
//    public int EmployeeID;
//    public string EmployeeName;
//    public int EmployeePhone;
//    public void EmpDetails()
//    {
//        Console.WriteLine("Company Name: " + CompanyName + "\nCompanyID :" + CompanyID +
//            "\nCompanyType: " + CompanyType + "\nEmployeeID: " + EmployeeID + "\nEmployeeName: "
//            + EmployeeName + "\nEmployeePhone : " + EmployeePhone);
//    }
//}
//class Trainee : Kalpita
//{
//    public int TraineeID;
//    public string TraineeName;
//    public int TraineePhone;
//    public void TraineeDetails()
//    {
//        Console.WriteLine("Company Name: " + CompanyName + "\nCompanyID :" + CompanyID +
//            "\nCompanyType: " + CompanyType + "\nTraineeID: " + TraineeID + "\nTraineeName: " + TraineeName +
//             "\nTraineePhone: " + TraineePhone);
//    }
//    class Test
//    {
//        static void Main()
//        {
//            Employee Emp = new Employee();
//            Console.WriteLine("****************Employee Details****************");
//            Emp.EmployeeID = 100502;
//            Emp.EmployeeName = "Pearlin";
//            Emp.EmployeePhone = 960600000;
//            Emp.EmpDetails();
//            Trainee Tr = new Trainee();
//            Console.WriteLine("****************Trainee Details****************");
//            Tr.TraineeID = 068932;
//            Tr.TraineeName = "Nishanth";
//            Tr.TraineePhone = 960698774;
//            Tr.TraineeDetails();
//        }


//    }
//}





                                                //Encapsulation//


// class Banking
//    {
//        public string BankName = "HDFC";
//        private string Password = "0974721";
//        public string AccountNo { get; set; }
//        public string AccountentName { get; set; }
//        public string Email { get; set; }
//        public string Address { get; set; } 
// }
//class AccountHolder
//{
//    static void Main(string[] args)
//    {
//        Banking B = new Banking();
//        B.BankName = "HDFC";
//        B.AccountNo = "96876330001";
//        B.AccountentName = "Nishanth";
//        B.Email = "Moddu.Nishanth@HDFC.com";
//        B.Address = "Bangalore";
//        Console.WriteLine("Bank Name = " + B.BankName);
//        Console.WriteLine("AccountNo = " + B.AccountNo);
//        Console.WriteLine("AccountentName = " + B.AccountentName);
//        Console.WriteLine("Email = " + B.Email);
//        Console.WriteLine("Address= " + B.Address);
//    }


//}




                                                      //Abstraction//


//abstract class Human
//{
//    public abstract void HumanName();
//    public void Talking()
//    {
//        Console.WriteLine("He Is Talking");
//    }
//}
//class men : Human
//{
//    public override void HumanName()
//    {
//        Console.WriteLine("The Name of the Human is Nishanth");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        men m = new men();
//        m.HumanName();
//        m.Talking();
//    }
//}




                                                      //Interface//


//interface Engineering
//{
//    void CollegeName();
//    void CollegeBranch();
//}

//class Branch : Engineering
//{
//    public void CollegeName()
//    {
//        Console.WriteLine("Gkce");
//    }

//    public void CollegeBranch()
//    {
//        Console.WriteLine("Computer Science");
//    }
//}
//public class Result
//{
//    public static void Main()
//    {
//        Branch B = new Branch();
//        B.CollegeName();
//        B.CollegeBranch();
//    }
//}




                                                    //Pholymorphism//
                                                 //Runtime Pholymorphism//

//public class Shopping
//{
//    public virtual void buy()
//    {
//        Console.WriteLine("Buying the Clothes...");
//    }
//}
//public class customer : Shopping
//{
//    public override void buy()
//    {
//        Console.WriteLine("Shopping is Done with 10000rs...!");
//    }

//}
//public class Bill
//{
//    public static void Main()
//    {
//        Shopping a = new customer();
//        a.buy();
//    }
//}




                                       //Compilke time Pholymorphism//


//public class Kalpita
//{
//    public virtual void work()
//    {
//        Console.WriteLine("Kalipta working...!");
//    }
//}
//public class Employee : Kalpita
//{
//    public override void work()
//    {
//        Console.WriteLine("Employees Working..!");
//    }

//}
//public class Trainee : Kalpita
//{
//    public override void work()
//    {
//        Console.WriteLine("Trainees are Learning...!");
//    }

//}
//public class project
//{
//    public static void Main()
//    {
//        Kalpita s = new Kalpita();
//        s.work();
//        Kalpita e = new Employee();
//        e.work();
//        Kalpita t = new Trainee();
//        t.work();

//    }
//}
