using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace firstSessionwindowsform.classes
{
    public class ConvertJsonToText
    {
        public static void TeacherJsonConvert()
        {
            string jsonDataFilePah = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TecherList");
            string jsonDataStr = File.ReadAllText(jsonDataFilePah);
            List<TeacherList> teacherList = JsonConvert.DeserializeObject<List<TeacherList>>(jsonDataStr);
            Console.WriteLine(jsonDataStr);
        }
    }
}
