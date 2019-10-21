using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        { 
            new Candy {CandyId = 1, Name="Assorted Hard Candy", Price = 4.95M, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://upload.wikimedia.org/wikipedia/commons/1/13/HardCandy.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/220px-HardCandy.jpg"},
            new Candy {CandyId = 2, Name="Assorted Chocolate Candy", Price = 5.95M, Description="Rhoncus aenean vel elit scelerisque mauris. Etiam sit amet nisl purus. Tortor at auctor urna nunc id cursus metus. In hendrerit gravida rutrum quisque non tellus orci ac auctor. Lobortis elementum nibh tellus molestie nunc non blandit massa. Blandit volutpat maecenas volutpat blandit aliquam etiam. Integer feugiat scelerisque varius morbi enim nunc faucibus a pellentesque. Id diam maecenas ultricies mi eget mauris. Viverra mauris in aliquam sem. Nisl purus in mollis nunc. A scelerisque purus semper eget. Neque ornare aenean euismod elementum nisi quis. Aliquet eget sit amet tellus cras adipiscing.", Category = _categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://en.wikipedia.org/wiki/Chocolate#/media/File:Chocolate_(blue_background).jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg"},
            new Candy {CandyId = 3, Name="Assorted Fruit Candy", Price = 3.95M, Description="Nisl suscipit adipiscing bibendum est ultricies integer. Fringilla est ullamcorper eget nulla facilisi etiam. Convallis a cras semper auctor neque vitae tempus quam. Lacus vestibulum sed arcu non odio. Faucibus purus in massa tempor nec feugiat nisl pretium fusce. Nibh sed pulvinar proin gravida. Tortor at auctor urna nunc id cursus. Malesuada nunc vel risus commodo. Gravida cum sociis natoque penatibus et magnis dis parturient montes. Donec adipiscing tristique risus nec feugiat in fermentum posuere urna. Amet commodo nulla facilisi nullam vehicula ipsum a arcu. Mattis nunc sed blandit libero volutpat. Ipsum dolor sit amet consectetur adipiscing.", Category = _categoryRepository.GetAllCategories.ToList()[2], ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Betty_Crocker_Fruit_Gushers_pieces.jpg/1024px-Betty_Crocker_Fruit_Gushers_pieces.jpg",IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Betty_Crocker_Fruit_Gushers_pieces.jpg/220px-Betty_Crocker_Fruit_Gushers_pieces.jpg"}
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
