using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_Github_Tajek
{
    public static class ModeleMission1
    {
        private static PPE3_TAJEKEntities maConnexion;

        private static Visiteur utilisateurConnecte;
        private static bool connexionValide;


        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new PPE3_TAJEKEntities();
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
        byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
        StringBuilder sb = new StringBuilder();
            for (int i = 0; i<hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static string validConnexion(string id, string mp)
    {
    string message = "";
    // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
    return message;
    }

    }
}
