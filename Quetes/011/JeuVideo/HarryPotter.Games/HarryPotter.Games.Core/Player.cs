using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Class qui représente le joueur, la joueuse dans le jeu
    /// </summary>
    public class Player : Character
    {
        #region Fields
        private string email = "";
        private string? prenom;
        private DateOnly dateDeNaissance;

        private Player[] Amis = new Player[3];
        private Force? force { get; set; }
        #endregion

        #region Constructors

        public Player() : this(string.Empty, DateOnly.MinValue) { }

        public Player(string pseudo, DateOnly dateNaissance) : base(pseudo)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(string pseudo) : this(pseudo, DateOnly.MinValue) {}

        public Player(DateOnly dateNaissance): this(string.Empty, dateNaissance) {}

        #endregion

        #region Properties
        public DateOnly DateDeNaissance
        {
            get
            {
                return this.dateDeNaissance;
            }
            set
            {
                if (value == DateOnly.MinValue)
                {
                    throw new ArgumentException("dateDeNaissance");
                }

                this.dateDeNaissance = value;
            }
        }

        public string Email { get => email; set => email = value; }

        //public DateOnly GetDateDeNaissance()
        //{
        //    return this.dateDeNaissance;
        //}
        //public void SetDateDeNaissance(DateOnly value)
        //{
        //    this.dateDeNaissance = value;
        //}

        /// <summary>
        /// Points de vie, max à 100 (au début du jeu)
        /// </summary>
        public int PointsDeVie { get; set; }
        #endregion

        #region Methodes

        public override void SeDeplacer()
        {
            //sbase.SeDeplacer();
            System.Console.WriteLine($"{this.Prenom} Je cours");
        }

        public void setForce(Force force)
        {
            this.force = force;
            force.setPlayer(this);
        }

        #endregion
    }
}
