using Microsoft.Extensions.Localization;
using Portfolio.Models;

namespace Portfolio.Services;
public class repoProjects
{
    private readonly IStringLocalizer<repoProjects> _localizer;

    public repoProjects(IStringLocalizer<repoProjects> localizer)
    {
        _localizer = localizer;
    }

    public List<Proyecto> GetProjects()
    {
        return new List<Proyecto> {
            new Proyecto
            {
                Titulo = _localizer["XproyectoTitulo"],
                Descripcion = _localizer["XproyectoDescripcion"],
                Fecha = _localizer["XproyectoFecha"],
                Tecnologia1 = "Golang",
                Tecnologia2 = "MongoDB",
                Imagen = "./img/api.png",
                Link = "https://github.com/Rck23/XGo"

            },
            new Proyecto
            {
                Titulo = _localizer["eneproyectoTitulo"],
                Descripcion = _localizer["eneproyectoDescripcion"],
                Fecha = _localizer["eneproyectoFecha"],
                Tecnologia1 = "Vue.js",
                Tecnologia2 = "MongoDB",
                Imagen = "./img/pacientes.png",
                Link = "https://github.som/Rck23"

            },
            new Proyecto
            {
                Titulo = _localizer["VeterinariaproyectoTitulo"],
                Descripcion = _localizer["VeterinariaproyectoDescripcion"],
                Fecha = _localizer["VeterinariaproyectoFecha"],
                Tecnologia1 = "JavaScript",
                Tecnologia2 = "React.js",
                Imagen = "./img/pacientes.png",
                Link = "https://pacientesv.netlify.app/"

            },
            new Proyecto
            {
                Titulo = _localizer["tiendapiproyectoTitulo"],
                Descripcion = _localizer["tiendapiproyectoDescripcion"],
                Fecha = _localizer["tiendapiproyectoFecha"],
                Tecnologia1 = "C#, .Net 6",
                Tecnologia2 = "MySQL",
                Imagen = "./img/api.png",
                Link = "https://github.com/Rck23/Tienda_API"

            },
            new Proyecto
            {
                Titulo = _localizer["instagramproyectoTitulo"],
                Descripcion = _localizer["instagramproyectoDescripcion"],
                Fecha = _localizer["instagramproyectoFecha"],
                Tecnologia1 = "Php, Laravel 8",
                Tecnologia2 = "MySQL",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Instagram-Clone"

            },
            new Proyecto
            {
                Titulo = _localizer["tareasproyectoTitulo"],
                Descripcion = _localizer["tareasproyectoDescripcion"],
                Fecha = _localizer["tareasproyectoFecha"],
                Tecnologia1 = "C# .Net 7",
                Tecnologia2 = "SQL Server",
                Imagen = "./img/tareasmvc.png",
                Link = "https://github.com/Rck23/TareasMVC"

            },
            new Proyecto
            {
                Titulo = _localizer["presupuestoproyectoTitulo"],
                Descripcion = _localizer["presupuestoproyectoDescripcion"],
                Fecha = _localizer["presupuestoproyectoFecha"],
                Tecnologia1 = "C# .Net 6",
                Tecnologia2 = "MySQL",
                Imagen = "./img/presupuesto.png",
                Link = "https://github.com/Rck23/Manejo-Presupuesto"

            },
         
            new Proyecto
            {
                Titulo = _localizer["portafolioproyectoTitulo"],
                Descripcion = _localizer["portafolioproyectoDescripcion"],
                Fecha = _localizer["portafolioproyectoFecha"],
                Tecnologia1 = "C# .Net 6",
                Tecnologia2 = "MVC",
                Imagen = "./img/portafolio.png",
                Link = "https://github.com/Rck23/Portfolio_v2"

            },new Proyecto
            {
                Titulo = _localizer["climaproyectoTitulo"],
                Descripcion = _localizer["climaproyectoDescripcion"],
                Fecha = _localizer["climaproyectoFecha"],
                Tecnologia1 = "JavaScript",
                Tecnologia2 = "React.js",
                Imagen = "./img/pacientes.png",
                Link = "https://github.com/Rck23/Clima_App_React"

            }


        };

    }
}
