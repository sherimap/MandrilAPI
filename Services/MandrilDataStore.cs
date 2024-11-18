//In memory Storage
using MandrilAPI.Models;

namespace MandrilAPI.Services;

public class MandrilDataStore
{
    public List<Mandril>Mandriles {  get; set; }

    public static MandrilDataStore Current { get; } = new MandrilDataStore();


    public MandrilDataStore()
    {
        Mandriles = new List<Mandril>()
        {
            new Mandril()
            {
                Id = 1,
                Nombre= "Mini Mandril",
                Apellido= "Rodriguez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
             new Mandril()
            {
                Id = 2,
                Nombre= "SuperMandril",
                Apellido= "Fernandez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Camina",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
             new Mandril()
            {
                Id = 3,
                Nombre= "TazerMandril",
                Apellido= "Mendez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Volar",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
              new Mandril()
            {
                Id = 4,
                Nombre= "MegaMandril",
                Apellido= "Perez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 4,
                        Nombre = "Levita",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
               new Mandril()
            {
                Id = 5,
                Nombre= "UltraMandril",
                Apellido= "Tevez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 5,
                        Nombre = "Teletransporta",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
                              new Mandril()
            {
                Id = 6,
                Nombre= "ArchiMandril",
                Apellido= "Velasquez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Salta",
                        Potencia = Habilidad.EPotencia.Moderado
                    },
                    new Habilidad()
                    {
                        Id = 6,
                        Nombre = "Corre",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 7,
                        Nombre = "RayoLaser",
                        Potencia = Habilidad.EPotencia.RePötente
                    }
                }
            }

        };
    }
}
