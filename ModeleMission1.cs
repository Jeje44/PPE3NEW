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

        public static Visiteur unVisiteur , unVisiteurCo;
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
            return ("0x"+sb.ToString().ToUpper());
        }
        public static string validConnexion(string identifiant, string mp)
        {
            string message = "";
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == identifiant);
            unVisiteur = (Visiteur)LQuery.First();
           
            
                if (unVisiteur.password.ToString() == GetMd5Hash(mp.ToString()))
                {
                unVisiteurCo = unVisiteur;
                    connexionValide = true;
                   
                    message = message + "Connecté";
                }
                else
                {
                    
                    connexionValide = false;
                    message = message + "Erreur de mot de passe ou Identifiant incorrect";
                }

            
            maConnexion.SaveChanges();
            return message;
        }

         public static bool getConnexionValide()
        {
            return connexionValide; 
        }

        public static bool ModifVisiteur(String adresse, string CP, string Ville)
        {
            bool vertour = true;
            try
            {
                unVisiteur.cp = CP;
                unVisiteur.rue = adresse;
                unVisiteur.ville = Ville;
                maConnexion.SaveChanges();
            }
            catch(Exception ex)
            {
                vertour = false; 
            }
            return vertour;
           
        }
        public static bool possèdeUneRégion ()
        {
            bool vretour = false;

            return vretour; 
        }

    }
}
