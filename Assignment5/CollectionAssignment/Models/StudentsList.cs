using System.Collections;
using System.Collections.Generic;
namespace CollectionAssignment.Models
{
    public class StudentsList
    {
        private int sid{get;set;}
        private string sname{get;set;} 
    }
    /* public class StudentList
     {
        public ArrayList StudentDetails()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("Salman Ahmed");
            arrayList.Add("Gurpreet Singh");
            return arrayList;
        }  
     } */
     public class StudentListGenerics
     {
        public List<StudentsList> StudentDetails()
        {
            List<StudentsList> objlist=new List<StudentsList>();     
            objlist.Add(new StudentsList{
                sid="Salman Ahmed",  
            });
            return ; 
        }
     }
    }
