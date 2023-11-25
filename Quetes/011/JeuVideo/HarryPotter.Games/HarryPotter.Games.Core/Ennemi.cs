﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    public class Ennemi : Character
    {
        #region Constants
        public const int DEFAULT_POINTS_DE_VIE = 100;
        #endregion

        #region Constructors
        public Ennemi(string prenom): base(prenom) {}
        #endregion


        #region Properties
        /// <summary>
        /// Points de vie, max à 100 (au début du jeu)
        /// </summary>
        public int PointsDeVie { get; set; } = DEFAULT_POINTS_DE_VIE;
        #endregion

        #region Methodes

        public override void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Prenom} Je saute");
        }

        #endregion
    }
}
