using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHerlper = new();
//exportHerlper.ExportStudends(studentRepository.GetAll());
await exportHerlper.ExportCSVGeneric(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");