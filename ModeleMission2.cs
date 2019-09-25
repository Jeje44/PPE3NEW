using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Github_Tajek
{
    class ModeleMission2
    {
        private static PPE3_TAJEKEntities maConnexion;
        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new PPE3_TAJEKEntities();
        }
    }
}
