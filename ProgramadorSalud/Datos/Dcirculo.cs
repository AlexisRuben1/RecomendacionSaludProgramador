using ProgramadorSalud.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ProgramadorSalud.Datos
{
    public class Dcirculo
    {
        public ObservableCollection<Mcirculo> Listarcirculo()
        {
            return new ObservableCollection<Mcirculo>()
            {
                new Mcirculo()
                {   descripcioncorta="Una mala postura puede causar muchos problemas de salud...",
                    descripcion="Una mala postura puede causar muchos problemas de salud, como dolores de espalda y cuello. Para mantener una buena postura, asegúrate de sentarte con la espalda recta y los pies en el suelo. Si trabajas en una laptop, considera utilizar un soporte para laptop y un teclado externo para ayudarte a mantener una buena postura.",
                    tema="Mantén una buena postura",
                    icono="https://i.ibb.co/Jrk54SD/postura.png"
                },
                new Mcirculo()
                {   descripcioncorta="Mantener la vista fija en la pantalla durante largas horas puede cansar tus ojos...",
                    descripcion="Mantener la vista fija en la pantalla durante largas horas puede cansar tus ojos y causar fatiga visual. Para descansar tus ojos, sigue la regla 20-20-20: cada 20 minutos, mira algo a 20 pies de distancia durante 20 segundos. También puedes ajustar el brillo y el contraste de tu pantalla para que no sea demasiado brillante.",
                    tema="Descansar ojos",
                    icono="https://i.ibb.co/gDHnr7K/ojo.png"
                },
                new Mcirculo()
                {   descripcioncorta="Beber suficiente agua es fundamental para mantener...",
                    descripcion="Beber suficiente agua es fundamental para mantener nuestro cuerpo hidratado y funcionando correctamente. Es recomendable beber al menos ocho vasos de agua al día para mantenerse hidratado.",
                    tema="Beber agua",
                    icono="https://i.ibb.co/txr1SLF/beber.png"
                },
                new Mcirculo()
                {   descripcioncorta="La actividad física es esencial para...",
                    descripcion="La actividad física es esencial para mantener una buena salud. Aunque la programación puede ser un trabajo sedentario, es importante hacer ejercicio regularmente. Caminar, correr, hacer yoga o ir al gimnasio son algunas opciones para incorporar actividad física en tu rutina.",
                    tema="Haz ejercicio regularmente",
                    icono="https://i.ibb.co/fQt6XB4/ejercicio.png"
                },
                new Mcirculo()
                {   descripcioncorta="Es importante tomar descansos...",
                    descripcion="Es importante tomar descansos regulares durante el día para estirarte, caminar y hacer ejercicios de respiración. Una buena práctica es hacer una pausa de cinco minutos cada hora para evitar la fatiga y el estrés.",
                    tema="Haz pausas regulares",
                    icono="https://i.ibb.co/3FBKjY3/pausa.png"
                }

            };
        }
    }
}
