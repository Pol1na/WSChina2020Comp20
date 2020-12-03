using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSChina2020AppComp20.Entities;

namespace WSChina2020AppComp20
{
    public class AppData
    {
        public static Entities.WSChina2020BaseComp20Entity Context = new Entities.WSChina2020BaseComp20Entity();
        public static Users currentUser;
    }
}
