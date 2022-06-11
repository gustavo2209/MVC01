using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC01.domain;

namespace MVC01.Models
{
    public class DaoTutoriales
    {
        public List<Tutoriales> tutorialesQry()
        {
            Tutoriales t1 = new Tutoriales();
            Tutoriales t2 = new Tutoriales();
            Tutoriales t3 = new Tutoriales();

            t1.Titulo = "Titulo 1";
            t1.Tipo = "Separata";
            t1.Precio = 20.0;

            t2.Titulo = "Titulo 2";
            t2.Tipo = "Video";
            t2.Precio = 30.0;

            t3.Titulo = "Titulo 3";
            t3.Tipo = "Separata";
            t3.Precio = 15.0;

            List<Tutoriales> list = new List<Tutoriales>();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);

            return list;
        }
    }
}