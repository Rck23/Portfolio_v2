using Portfolio.Models;

namespace Portfolio.Services;
public class repoProjects
{
    public List<Proyecto> GetProjects()
    {
        return new List<Proyecto> {
            new Proyecto
            {
                Titulo = "Twitter (X) API",
                Descripcion = "Clon de Twitter (X) realizado con AWS Lambda escrita en Go que maneja eventos de API Gateway. Conectado a MongoDB Atlas.",
                Fecha = "Julio 2024",
                Tecnologia1 = "Golang",
                Tecnologia2 = "MongoDB",
                Imagen = "./img/api.png",
                Link = "https://github.com/Rck23/XGo"

            },
            new Proyecto
            {
                Titulo = "Ecommerce (MEVN)",
                Descripcion = "Proyecto prácticas profesionales de Ing.",
                Fecha = "Abril 2024",
                Tecnologia1 = "Vue.js",
                Tecnologia2 = "MongoDB",
                Imagen = "./img/pacientes.png",
                Link = "https://github.som/Rck23"

            },
            new Proyecto
            {
                Titulo = "Pacientes Veterinaria",
                Descripcion = "Web donde se da seguimiento a pacientes muy básico utilizando LocalStorage y Tailwind CSS.",
                Fecha = "Agosto 2023",
                Tecnologia1 = "JavaScript",
                Tecnologia2 = "React.js",
                Imagen = "./img/pacientes.png",
                Link = "https://pacientesv.netlify.app/"

            },
            new Proyecto
            {
                Titulo = "Tienda API",
                Descripcion = "API destinada a realizar todas las acciones de una tienda online, " +
                "contiene una Web Api y dos librerías (Core e Infrastructure) para su correcto funcionamiento.",
                Fecha = "Abril 2023",
                Tecnologia1 = "C#, .Net 6",
                Tecnologia2 = "MySQL",
                Imagen = "./img/api.png",
                Link = "https://github.com/Rck23/Tienda_API"

            },
            new Proyecto
            {
                Titulo = "Instagram Clon",
                Descripcion = "Copia de la aplicación Instagram para fines educativos universitarios, manejando" +
                "librerias como \"vite\" & \"dropzone\".",
                Fecha = "Abril 2023",
                Tecnologia1 = "Php, Laravel 8",
                Tecnologia2 = "MySQL",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Instagram-Clone"

            },
            new Proyecto
            {
                Titulo = "Tareas (MVC)",
                Descripcion = "Este sitio web te permite " +
                "crear, completar, modificar & eliminar" +
                " tareas o cualquier cosa" +
                " tengas pendiente (como una lista To Do), " +
                "las tareas se muestran por usuario y a cada " +
                "tarea se le puede asignar subtareas e imagenes" +
                "(guardadas de forma local).",
                Fecha = "Febrero 2023",
                Tecnologia1 = "C# .Net 7",
                Tecnologia2 = "SQL Server",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/TareasMVC"

            },
            new Proyecto
            {
                Titulo = "Manejo de presupuesto",
                Descripcion = "Este sitio web te permite manejar tus finanzas por día, mes, año y te muestra\r\n                        los diferentes gastos e ingresos, ademas cuentas con categorias, transacciones, reportes,\r\n                        cuentas y tipos de cuentas.",
                Fecha = "Enero 2023",
                Tecnologia1 = "C# .Net 6",
                Tecnologia2 = "MySQL",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Manejo-Presupuesto"

            },
         
            new Proyecto
            {
                Titulo = "Mi portafolio",
                Descripcion = "Visita el código de este portafolio.",
                Fecha = "Diciembre 2022",
                Tecnologia1 = "C# .Net 6",
                Tecnologia2 = "MVC",
                Imagen = "./img/portafolio.png",
                Link = "https://github.com/Rck23/Portfolio_v2"

            },new Proyecto
            {
                Titulo = "Pronóstico del Tiempo",
                Descripcion = "Sitio web que te permite realizar una busqueda a la vez por ciudad del clima en tiempo real y\r\n                        muestra\r\n                        predicciones para las proximas horas.",
                Fecha = "Diciembre 2021",
                Tecnologia1 = "JavaScript",
                Tecnologia2 = "React.js",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Clima_App_React"

            }


        };

    }
}
