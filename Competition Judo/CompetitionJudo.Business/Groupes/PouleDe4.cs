﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitionJudo.Business
{
    public class PouleDe4 : Poule
    {
        public PouleDe4(List<Competiteur> grilleCompetiteurs)
        {
            this.grilleCompetiteurs = grilleCompetiteurs;
            this.sourceImage = "img\\templateP4.png";
            CreerCoordonnees();
        }

        public override void CreerFeuille()
        {
        }

        public override void CreerCoordonnees()
        {

            listeCoordonneesNom = new List<Coordonnee>();
            listeCoordonneesPrenom = new List<Coordonnee>();
            listeCoordonneesClub = new List<Coordonnee>();
            var n1 = new Coordonnee(15, 205);
            var n2 = new Coordonnee(15, 260);
            var n3 = new Coordonnee(15, 315);
            var n4 = new Coordonnee(15 ,370);
            listeCoordonneesNom.Add(n1);
            listeCoordonneesNom.Add(n2);
            listeCoordonneesNom.Add(n3);
            listeCoordonneesNom.Add(n4);
            var p1 = new Coordonnee(170, 205);
            var p2 = new Coordonnee(170, 260);
            var p3 = new Coordonnee(170, 315);
            var p4 = new Coordonnee(170, 370);
            listeCoordonneesPrenom.Add(p1);
            listeCoordonneesPrenom.Add(p2);
            listeCoordonneesPrenom.Add(p3);
            listeCoordonneesPrenom.Add(p4);
            var cl1 = new Coordonnee(295, 205);
            var cl2 = new Coordonnee(295, 260);
            var cl3 = new Coordonnee(295, 315);
            var cl4 = new Coordonnee(295, 370);
            listeCoordonneesClub.Add(cl1);
            listeCoordonneesClub.Add(cl2);
            listeCoordonneesClub.Add(cl3);
            listeCoordonneesClub.Add(cl4);



        }
    }
}
