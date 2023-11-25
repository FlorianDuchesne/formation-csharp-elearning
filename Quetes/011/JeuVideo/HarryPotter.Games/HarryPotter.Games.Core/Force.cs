using System;
namespace HarryPotter.Games.Core
{
	public abstract class Force
	{

		#region propriétés

        protected int Id { get; set; }
		protected string Libelle { get; set; }
        protected Player? Player { get; set; }

        #endregion

        #region methodes

        public void SetPlayer(Player player)
        {
            this.Player = player;
        }

        public override string ToString()
        {
            return this.Libelle;
        }

        #endregion

        #region constructeurs

        //public Force() : this(string.Empty) { } 

        public Force(string libelle)
		{
            this.Libelle = libelle;
		}

        #endregion
    }
}

