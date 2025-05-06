using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAtoutV1_Gautret_Ethan.Models
{

        public static class ModelProjet
        {
            private static Sio2musicAtoutGautretContext monModel;
            private static int actionGestionCompositeur;
            private static Compositeur compositeurChoisi;

        public static Sio2musicAtoutGautretContext MonModel { get => monModel; set => monModel = value; }
        public static int ActionGestionCompositeur { get => actionGestionCompositeur; set => actionGestionCompositeur = value; }
        public static Compositeur CompositeurChoisi { get => compositeurChoisi; set => compositeurChoisi = value; }


        public static void init()
            {
                MonModel = new Sio2musicAtoutGautretContext();
            }
            public static List<Ville> listeVille()
            {
                return MonModel.Villes.ToList();
            }



        public static Compositeur select(int id)
        {
            Compositeur vretour;
            vretour = monModel.Compositeurs.Where(x => x.IdCompositeur == id).ToList()[0];
            return vretour; 
        }



        public static List<Salle> listeSalle()
        {
            return MonModel.Salles.ToList();
        }

        public static List<Batiment> listeBatiment()
        {
            return MonModel.Batiments.ToList();
        }
        public static List<Typeoeuvre> listeTypeoeuvre()
        {
            return MonModel.Typeoeuvres.ToList();
        }
        public static List<Nationalite> listeNationalite()
        {
            return MonModel.Nationalites.ToList();
        }
        public static List<Compositeur> listeCompositeur()
        {
            return MonModel.Compositeurs.ToList();
        }
        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }
        public static List<Oeuvre> listeOeuvre()
        {
            return MonModel.Oeuvres.ToList();
        }


        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi = new Compositeur();
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;
                monModel.Compositeurs.Add(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static bool ModifCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppCompositeur()
        {
            bool vretour = true;
            try
            {
                monModel.Compositeurs.Remove(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }


    }



}