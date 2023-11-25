using System;
namespace HarryPotter.Games.Core
{
	public class ItemMenu :Menu
	{
        #region fields
        private readonly string item;
        private readonly int index; 
        #endregion

        #region properties
        public string Item { get { return item; } }
        public int Index { get { return index; } }
        private List<Menu> Menus { get; set; }
        
        #endregion

        #region methods
        public void AddMenu(Menu menu)
        {
            this.Menus.Add(menu);
        }

        public override string ToString()
        {
            return $"{this.index}. {this.item}";
        }

        #endregion

        #region constructors
        public ItemMenu(int index, string item)
		{
            this.item = item;
            this.index = index;
            this.Menus = new List<Menu>();
		}
        #endregion

    }
}

