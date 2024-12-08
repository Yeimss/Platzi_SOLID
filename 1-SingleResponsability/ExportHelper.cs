using System.Text;

namespace SingleResponsability{

    public class ExportHelper{
        public void ExportStudends( IEnumerable<Student> students ){
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }

        public async Task ExportCSVGeneric (IEnumerable<dynamic> data){
            string csv = String.Join(",", data.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string claves = await obtenerClaves(data);
            sb.AppendLine(claves);
            
            foreach (var item in data.ToList())
            {
                string linea = "";
                foreach (var prop in item.GetType().GetProperties())
                {
                    var value = prop.GetValue(item);

                    if (value.GetType().IsGenericType && value.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        linea += $"{string.Join("|", value)};";
                    }
                    else
                    {
                        linea += $"{value};";
                    }

                }
                int length = linea.Length-1;
                linea = linea.Substring(0, length);
                sb.AppendLine(linea);
                System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
            }
        }
        private async Task<string> obtenerClaves(IEnumerable<dynamic> data)
        {
            var firstItem = data.FirstOrDefault();
            if (firstItem == null)
            {
                return "";
            }
            List<string> claves = new List<string>();
            if (firstItem is IDictionary<string, object> dictionary)
            {
                claves = dictionary.Keys.ToList();
            }
            else
            {
                var properties = firstItem.GetType().GetProperties();
                foreach (var property in properties)
                {
                    claves.Add(property.Name);
                }
            }

            string clavesStr = string.Join(",", claves);
            return clavesStr;
        }

    }
}