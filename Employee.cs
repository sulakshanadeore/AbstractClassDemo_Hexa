namespace OOPsContinuedAbstractDemo
{
    public abstract class Employee
    {
    static   int _empid;

        string _name;
        static Employee() {
            _empid = 0;
            //_name = null;//non static is not allowed in static method----ERROR
        
        }
        public string EmpName { get; set; }
        public int Empid 
        {
            get 
            {
                _empid = _empid + 1;
                return _empid; 
            } 
       
                
       
        }

        public abstract string Designation { get; set; }
        public  abstract void CalculateSalary(int bs);

    }
}
