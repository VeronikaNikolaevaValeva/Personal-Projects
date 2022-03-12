using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WorkshopManagement_AssignmentWeek12
{
    public class WorkshopDAL: IWorkshopDAL
    {
        public WorkshopDAL()
        {
        }

        public void WriteWorkshopsToTextFile(List<Workshop> listOfAllAvailableWorkshops, string filename)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);

                foreach (Workshop workshop in listOfAllAvailableWorkshops)
                {
                    sw.WriteLine($"{workshop.SaveInformation()}");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
