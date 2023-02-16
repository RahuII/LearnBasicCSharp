using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace LearnBasic
{
    class LINQ
    {
        static void Main(string[] args)
        {
            string studentsXML = @"<Students>
                                    <Student> 
                                        <Name>Rahul></Name>
                                        <Age>21</Age>
                                        <University>Marwadi</University>
                                    </Student>
                                    <Student> 
                                        <Name>deep></Name>
                                        <Age>41</Age>
                                        <University>GTU</University>
                                    </Student>
                                    <Student> 
                                        <Name>Vipul></Name>
                                        <Age>65</Age>
                                        <University>Marwadi</University>
                                    </Student>
                                </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);
            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                           };

            foreach (var student in students)
            {
                System.Console.WriteLine("Student {0} with age {1} from University {2}", student.Name, student.Age, student.University);
            }

        }
    }

}