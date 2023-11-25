using System;
namespace HarryPotter.Games.Core
{
	public class Menu
	{

        #region properties

        private readonly List<ItemMenu> items = new List<ItemMenu>();
        #endregion

        #region methods
        public void Afficher()
        {
            foreach(ItemMenu item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void AddItem(ItemMenu item)
        {
            this.items.Add(item);
            item.AddMenu(this);
        }
        #endregion

        #region constructors
        public Menu() {}
        #endregion
    }
}

