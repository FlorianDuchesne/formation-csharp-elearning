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
        private readonly string? prenom;
        private DateOnly dateDeNaissance;

        private Player[] Amis = new Player[3];
        private Force? force;
        #endregion

        #region Constructors

        public Player(AfficherInformation afficher) : this(string.Empty, DateOnly.MinValue, afficher) { }

        public Player(string pseudo, DateOnly dateNaissance, AfficherInformation afficher) : base(pseudo, afficher)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(string pseudo, AfficherInformation afficher) : this(pseudo, DateOnly.MinValue, afficher) {}

        public Player(DateOnly dateNaissance, AfficherInformation afficher) : this(string.Empty, dateNaissance, afficher) {}

        #endregion

        #region Properties

        public Force? Force { get => force; set { } }
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
            this.afficher($"{this.Prenom} Je cours");
            //System.Console.WriteLine($"{this.Prenom} Je cours");
        }

        public void SetForce(Force force)
        {
            this.force = force;
            force.SetPlayer(this);
        }

        #endregion
    }
}
