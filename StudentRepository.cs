using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomrationData
{
    public class StudentRepository
    {
        public void AddStudent()
        {
            StudentInfo studentInfo = new StudentInfo();

            WmsContext wmsContext = new WmsContext();
            Console.WriteLine("Please Enter Name"); 
            studentInfo.Name =   Console.ReadLine();

            Console.WriteLine("Please Enter Address");
            studentInfo.Address = Console.ReadLine();

            Console.WriteLine("Please Enter Course");
            studentInfo.Course = Console.ReadLine();

           
            wmsContext.StudentInfos.Add(studentInfo);
            wmsContext.SaveChanges();

        }

        public void DeleteInfo()
        {
            WmsContext wmsContext = new WmsContext();
            Console.WriteLine("Please Enter Id to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            var recordToDelete = wmsContext.StudentInfos.Find(id);
            wmsContext.StudentInfos.Remove(recordToDelete);
            wmsContext.SaveChanges();   


        }

        public void DisplayStudent()
        {
            WmsContext wmsContext = new WmsContext();
            var d = wmsContext.StudentInfos.ToArray();
            
            foreach (var d2 in d)
            {
                Console.WriteLine(d2.Name);
                Console.WriteLine(d2.Id);
                Console.WriteLine(d2.Address);
                Console.WriteLine(d2.Course);   
            }
        }
    }
}
