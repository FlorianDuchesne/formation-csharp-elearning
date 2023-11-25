using System;
namespace HarryPotter.Games.Core
{
	public class ItemMenu
	{
        #region properties

        private string Item { get; set; }
        private int Index { get; set; }
        private List<Menu> Menus { get; set; }
        
        #endregion

        #region methods
        public int GetIndex()
        {
            return this.Index;
        }

        public string GetItem()
        {
            return this.Item;
        }

        public void addMenu(Menu menu)
        {
            this.Menus.Add(menu);
        }

        #endregion

        #region constructors
        public ItemMenu(int index, string item)
		{
            this.Item = item;
            this.Index = index;
            this.Menus = new List<Menu>();
		}
        #endregion

    }
}

