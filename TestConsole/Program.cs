﻿using AppliancesShop.BLL;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;

Context context = SingletoneStorage.GetStorage().Context;

//context.Shops.Add(new ShopDto()
//{
//	Name = "Магазин на Сенной",
//	Adress = "пл. Труда 4"
//});
//context.SaveChanges();

//context.Shops.Add(new ShopDto()
//{
//	Name = "Магазин на Лесной",
//	Adress = "ул. Кантемировская 26"
//});
//context.SaveChanges();

//context.Shops.Add(new ShopDto()
//{
//	Name = "Магазин в Озерках",
//	Adress = "пр. Энгельса 111"
//});
//context.SaveChanges();

//context.ProductTypes.Add(new ProductTypeDto()
//{
//	Name = "Холодильник",
//	Img="./images/fridge.png"
//});
//context.SaveChanges();

//context.ProductTypes.Add(new ProductTypeDto()
//{
//	Name = "Пылесос",
//	Img = "./images/vacuumcleaner.png"
//});
//context.SaveChanges();

//context.ProductTypes.Add(new ProductTypeDto()
//{
//	Name = "Микроволновая печь",
//	Img = "./images/microvawe.png"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//	Name = "Indesit ITR 5180 S",
//	Type = context.ProductTypes.Where(x => x.Id == 1).Single(),
//	Price = 33990,
//	Description = "Двухкамерный холодильник с нижним расположением морозильной камеры\r\n\r\nОбщие данные:\r\nРазмеры:\r\nвысота (см): 185\r\nширина (см): 60\r\nглубина (см): 64\r\n\r\nОбщий объем/ Полезный объем:\r\nХолодильника (л): -/298\r\nХолодильной камеры (л): -/220\r\nМорозильной камеры (л): -/78\r\n\r\nТип управления: электронный\r\nКласс энергопотребления: A\r\nКлиматический класс: N-ST (от +16 до +38 С)\r\nКоличество компрессоров: 1\r\nГодовое потребление энергии: 365 кВтч\r\nЦвет: серебристый\r\n\r\nХолодильное отделение:\r\nСверхпрочные полки из ударопрочного стекла (до 100 кг)\r\nСистема No Frost (Frost Free, Ноу Фрост)\r\nСветодиодное освещение\r\nФункция ускоренного охлаждения Push&Go\r\n1 ящик для овощей и фруктов\r\nПодставка для яиц\r\n\r\nМорозильное отделение:\r\nСистема No Frost (Frost Free, Ноу Фрост)\r\nВремя сохранения холода при отключении электроэнергии: 14 ч\r\nМощность замораживания: 4 кг/сутки\r\nУскоренная заморозка Freezer Control\r\n3 отделения\r\nКонтейнер для льда\r\n\r\nДополнительная информация:\r\nВнешний дисплей\r\nБоковая интегрированная ручка с нанесением TicTac",
//	Img = "https://holod.ru/pics/clean/medium/78/714078_0.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//	Name = "Karcher VC 2",
//	Type = context.ProductTypes.Where(x => x.Id == 2).Single(),
//	Price = 14490,
//	Description = "Пылесос VC 2 от Керхер поражает своей гигиеничной и удобной системой фильтрации: мешки утилизируются без контакта с грязью.\r\nЭтот пылесос идеален для использования в небольших домах и квартирах для тщательной уборки ковровых и твердых покрытий, а также, благодаря широкому набору аксессуаров для уборки в узких местах и на деликатных покрытиях.\r\nОдним из преимуществ является фильтр HEPA, который фильтрует самые мелкие частицы пыли.\r\nТакже из плюсов хранение насадок непосредственно на пылесосе, что делает его еще более практичным и удобным в использовании.",
//	Img = "https://holod.ru/pics/clean/medium/77/1087677_0.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//	Name = "Samsung MS23K3513AK/BW",
//	Type = context.ProductTypes.Where(x => x.Id == 3).Single(),
//	Price = 18499,
//	Description = "Функция \"Быстрая разморозка\" позволяет быстро и равномерно разморозить продукты. Специальный алгоритм автоматически рассчитывает время разморозки для 5-ти часто используемых типов продуктов, благодаря чему разморозка ингредиентов занимает меньше времени.\r\n\r\nЕсли Вы готовите несколько блюд, то функция \"Поддержание тепла\" с помощью гриля позволяет выдерживать приготовленные блюда при соответствующей температуре и не дает им перегреться. В результате блюдо остаётся как свежеприготовленное, теплое и сочное, готовое к подаче на стол.\r\n\r\nПрочное БИОкерамическое покрытие легко очищается и не царапается. Его гладкую поверхность можно очистить без использования жестких чистящих средств и кроме того оно не теряет цвет после длительной эксплуатации. Покрытие не подвержено коррозии, не царапается и служит долго.\r\n\r\nУдовлетворите Ваше желание попробовать свои способности приготовления традиционных блюд в домашних условиях с помощью запрограммированных рецептов национальной кухни. Вы можете приготовить любое из этих блюд одним нажатием кнопки и сэкономить время.\r\n\r\nРежим экономии ECO Mode обеспечивает минимальное энергопотребление в режиме ожидания, что уменьшит ваши счета за электричество.\r\n\r\nРежим \"Очистка от запахов\" позволяет легко и быстро удалить неприятные запахи из рабочей камеры. Благодаря немедленному удалению запаха, Ваше блюдо всегда остаётся свежим и аппетитным.\r\n",
//	Img = "https://holod.ru/pics/clean/medium/31/874931_0.jpg"
//});
//context.SaveChanges();


//ProductTypeRepository productTypeRepository = new();

//var productTypes = productTypeRepository.GetAllProductTypes();

//Console.WriteLine();


//ProductTypeClient productTypeClient = new();

//var productTypes = productTypeClient.GetAllProductTypes();

//Console.WriteLine();


//ProductClient productClient = new();

//var products = productClient.GetAllProducts();

//Console.WriteLine();