using System;
namespace HarryPotter.Games.Core
{
	public class Menu
	{

        #region properties

        protected List<ItemMenu> Items { get; set; }
        #endregion

        #region methods
        public void AfficherMenu()
        {
            string format = "{0}. {1}";
            foreach(ItemMenu Item in Items)
            {
                string resultatFormattage = string.Format(format, Item.GetIndex(), Item.GetItem().Substring(0, 1).ToUpper() + Item.GetItem().Substring(1).ToLower());
                Console.WriteLine(resultatFormattage);
            }
        }

        public void addItem(ItemMenu item)
        {
            this.Items.Add(item);
            item.addMenu(this);
        }
        #endregion

        #region constructors
        public Menu()
        {
            this.Items = new List<ItemMenu>();
        }
        #endregion
    }
}

