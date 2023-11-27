using System;
namespace HarryPotter.Games.Core
{

    /// <summary>
    /// Classe parente
    /// </summary>
	public abstract class Character
	{
        #region fields

        protected readonly AfficherInformation afficher;
        #endregion

        #region Constructors

        public Character(AfficherInformation afficher) : this(string.Empty, afficher) {}

        public Character(string prenom, AfficherInformation afficher)
        {
            this.afficher = afficher;
            this.Prenom = prenom;
        }

        #endregion

        #region properties
        /// <summary>
        /// propriétés du charactère, étendues aux classes héritées
        /// </summary>
        public string Prenom { get; set; } = string.Empty;

        public Position CurrentPosition { get; set; } = new Position() { X = 0, Y = 0 };
        #endregion

        #region Public methods
        /// <summary>
        /// Méthode qui permet de changer la position du joueur
        /// </summary>
        public virtual void SeDeplacer()
        {
            this.afficher($"{this.Prenom} Je me déplace");
            //System.Console.WriteLine($"{this.Prenom} Je me déplace");
        }
        public void SeDeplacer(Position newPosition)
        {
            //this.SeDeplacer();
            this.CurrentPosition = newPosition;
        }

        public void Attaquer(Character enemy)
        {
            this.afficher($"J'attaque le player {enemy}");
            //System.Console.WriteLine("J'attaque le player {0}", enemy);
        }
        #endregion
    }
}

