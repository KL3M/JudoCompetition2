﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitionJudo.Business
{
    public class TableauDe16 : Tableau
    {
        public TableauDe16(List<Competiteur> grilleCompetiteurs)
        {
            this.grilleCompetiteurs = grilleCompetiteurs;
            //this.sourceImage = "D:\\testT16.png";
        }

        public override void CreerFeuille()
        {
        }

        public override void CreerCoordonnees()
        {
            var c1 = new Coordonnee(100, 50);
            var c2 = new Coordonnee(120, 50);
            var c3 = new Coordonnee(140, 50);
            var c4 = new Coordonnee(160, 50);
            listeCoordonneesNom.Add(c1);
            listeCoordonneesNom.Add(c2);
            listeCoordonneesNom.Add(c3);
            listeCoordonneesNom.Add(c4);
        }
    }
}
