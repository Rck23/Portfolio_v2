using Portfolio.Models;

namespace Portfolio.Services;
public class repoProjects
{
    public List<Proyecto> GetProjects()
    {
        return new List<Proyecto> {
            new Proyecto
            {
                Titulo = "Ecommerce (MEVN)",
                Descripcion = "Proyecto prácticas profesionales.",
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
                Descripcion = "API destinada a realizar todas las acciones de una tienda online, contiene una Web Api y dos librerías (Core e Infrastructure) para su correcto funcionamiento.",
                Fecha = "Abril 2023",
                Tecnologia1 = "C# .Net 6",
                Tecnologia2 = "MySQL",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Tienda_API"

            },
            


        };

    }
}
