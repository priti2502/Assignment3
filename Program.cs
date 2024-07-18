namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountDuplicateElementcs elements=new CountDuplicateElementcs ();
            elements.displayCountDuplicate();

            Admission admission =new Admission ();
            admission.displayEligibleStudent();

            ElectricityBill bill= new ElectricityBill();
            bill.printElectricityBill();
        }
    }
}
