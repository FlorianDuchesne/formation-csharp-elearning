using System;
namespace HarryPotter.Games.Core
{

    /// <summary>
    /// Classe parente
    /// </summary>
	public class Character
	{

        #region Constructors

        public Character()
        {
            this.Prenom = String.Empty;
        }

        public Character(string prenom)
        {
            this.Prenom = prenom;
        }

        #endregion

        #region properties
        /// <summary>
        /// propriétés du charactère, étendues aux classes héritées
        /// </summary>
        public string Prenom { get; set; } = string.Empty;

        public Position currentPosition { get; set; } = new Position() { X = 0, Y = 0 };
        #endregion

        #region Public methods
        /// <summary>
        /// Méthode qui permet de changer la position du joueur
        /// </summary>
        public virtual void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Prenom} Je me déplace");
        }
        public void SeDeplacer(Position newPosition)
        {
            this.SeDeplacer();
            this.currentPosition = newPosition;
        }

        public void Attaquer(Character enemy)
        {
            System.Console.WriteLine("J'attaque le player {0}", enemy);
        }
        #endregion
    }
}

