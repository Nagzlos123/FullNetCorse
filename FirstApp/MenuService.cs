using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class MenuService
    {
        private readonly IEnumerable<Menu> _menus;

        public MenuService(IEnumerable<Menu> menu)
        {
            _menus = menu;
        }

        public IEnumerable<Menu> GetMenus() => _menus;

        public Menu? GetMenuById(int id)
        {
            foreach (var menu in _menus)
            {
                if (menu.Id == id) return menu;
            }
            return null;
        }
    }
}
