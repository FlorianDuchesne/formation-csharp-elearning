using System;
namespace HarryPotter.Games.Core
{
	public class Menu
	{

        #region properties

        private readonly List<ItemMenu> items = new List<ItemMenu>();
        #endregion

        #region methods
        public void Afficher(AfficherInformation afficher)
        {
            foreach(ItemMenu item in items)
            {
                //Console.WriteLine(item);
                afficher(item);
            }
        }

        public void AddItem(int id, string libelle)
        {
            ItemMenu item = new ItemMenu(id, libelle);
            this.items.Add(item);
            item.AddMenu(this);
        }
        #endregion

        #region constructors
        public Menu() {}
        #endregion
    }
}

