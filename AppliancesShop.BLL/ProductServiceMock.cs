using AppliancesShop.BLL.IServices;
using AppliancesShop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.BLL
{
    public class ProductServiceMock : IProductService
    {
        private List<ProductOutputModel> _outputModels;

        public ProductServiceMock()
        {
            _outputModels = new List<ProductOutputModel>()
            {
                new ProductOutputModel()
                {
                    Id = 1,
                    Name = "Холодильник Indesit ITR 5180 S",
                    Price=33990,
                    Description="Двухкамерный холодильник с нижним расположением морозильной камеры",
                    Img="https://holod.ru/pics/clean/medium/78/714078_0.jpg"
                },

                new ProductOutputModel()
                {
                    Id = 2,
                    Name = "Пылесос Karcher VC 2",
                    Price=14490,
                    Description="Пылесос VC 2 от Керхер поражает своей гигиеничной и удобной системой фильтрации: мешки утилизируются без контакта с грязью.\r\nЭтот пылесос идеален для использования в небольших домах и квартирах для тщательной уборки ковровых и твердых покрытий, а также, благодаря широкому набору аксессуаров для уборки в узких местах и на деликатных покрытиях.\r\nОдним из преимуществ является фильтр HEPA, который фильтрует самые мелкие частицы пыли.\r\nТакже из плюсов хранение насадок непосредственно на пылесосе, что делает его еще более практичным и удобным в использовании.",
                    Img="https://holod.ru/pics/clean/medium/77/1087677_0.jpg"
                },

                new ProductOutputModel()
                {
                    Id = 3,
                    Name = "Микроволновая печь Samsung MS23K3513AK/BW",
                    Price=18499,
                    Description="Функция \"Быстрая разморозка\" позволяет быстро и равномерно разморозить продукты. Специальный алгоритм автоматически рассчитывает время разморозки для 5-ти часто используемых типов продуктов, благодаря чему разморозка ингредиентов занимает меньше времени.\r\n\r\nЕсли Вы готовите несколько блюд, то функция \"Поддержание тепла\" с помощью гриля позволяет выдерживать приготовленные блюда при соответствующей температуре и не дает им перегреться. В результате блюдо остаётся как свежеприготовленное, теплое и сочное, готовое к подаче на стол.\r\n\r\nПрочное БИОкерамическое покрытие легко очищается и не царапается. Его гладкую поверхность можно очистить без использования жестких чистящих средств и кроме того оно не теряет цвет после длительной эксплуатации. Покрытие не подвержено коррозии, не царапается и служит долго.\r\n\r\nУдовлетворите Ваше желание попробовать свои способности приготовления традиционных блюд в домашних условиях с помощью запрограммированных рецептов национальной кухни. Вы можете приготовить любое из этих блюд одним нажатием кнопки и сэкономить время.\r\n\r\nРежим экономии ECO Mode обеспечивает минимальное энергопотребление в режиме ожидания, что уменьшит ваши счета за электричество.\r\n\r\nРежим \"Очистка от запахов\" позволяет легко и быстро удалить неприятные запахи из рабочей камеры. Благодаря немедленному удалению запаха, Ваше блюдо всегда остаётся свежим и аппетитным.\r\n",
                    Img="https://holod.ru/pics/clean/medium/31/874931_0.jpg"
                }
            };
        }
        public ProductOutputModel AddProduct(ProductInputModel product)
        {
            return new ProductOutputModel()
            {
                Id = 1,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Img = product.Img,
            };
        }

        public List<ProductOutputModel> GetAllProducts()
        {
            return _outputModels;
        }

        public ProductOutputModel GetProductById(int id)
        {
            return _outputModels[id-1];
        }
    }
}
