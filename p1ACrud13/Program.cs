



using p1ACrud13.Clases.entidades;
using p1ACrud13.Clases.Servicio;

ServicioAlumno alu = new();

//string cuerito = "select * from tb_alumnos where carnet='21-11951'";
//alu.lee(cuerito);
//Console.WriteLine("antes de cambiar");
//Console.ReadLine();
//alu.cambia();
//Console.WriteLine("Despues de cambiar");
//Console.ReadLine();
//alu.lee(cuerito);

string cuerito = "select * from tb_alumnos where seccion='C'";
//alu.lee(cuerito);
//Console.WriteLine("antes de cambiar");
//Console.ReadLine();

//string nombre = "Oscar zetagas";
//string carnet = "21-11432";
//string correo = "xx@xx.com";
//string clase = "Programacion";
//string seccion = "E";



//Console.Write("Ingrese  nombre");
//nombre = Console.ReadLine();


//Console.Write("Carnet");
//carnet = Console.ReadLine();



//alu.inserta(nombre,carnet,correo,clase,seccion);
//alu.lee(cuerito);


MdAlumnos oAlumno = new();

//oAlumno.nombre = "Roberto Lemus";
//oAlumno.carnet = "25-896";
//oAlumno.seccion = "e";
//oAlumno.correo = "gg@xx.com";
//oAlumno.clase = "Progra repro";

//alu.CrearAlumno(oAlumno);

//Console.WriteLine(oAlumno.ToString());

//alu.lee(cuerito);



oAlumno = alu.ObtenerAlumno("22-985");

if (oAlumno == null)
{
    Console.WriteLine($"quien es ese que no lo conozco ");
} else
{


    

    Console.WriteLine($"nombre: {oAlumno.nombre}");

    //Console.WriteLine(oAlumno.ToString());
    //oAlumno.clase = "Electronica";
    //alu.actualizarAlumno(oAlumno);
}













