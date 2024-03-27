using AppliancesShop.BLL;
using AppliancesShop.BLL.Models.OutputModels;
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

//context.Products.Add(new ProductDto()
//{
//    Name = "Liebherr Rsfe 5220",
//    Type = context.ProductTypes.Where(x => x.Id == 1).Single(),
//    Price = 115990,
//    Description = "Размеры:\r\nвысота (см): 185,5\r\nширина (см): 59,7\r\nглубина (см): 67,5\r\n\r\nОбщий объем/ Полезный объем:\r\nХолодильника (л): 412/398\r\nХолодильной камеры (л): 412/398\r\n\r\nКласс энергопотребления: A+\r\nКлиматический класс: SN-T (от +10°С до +43°С)\r\nКоличество компрессоров: 1\r\nТип компрессора: стандартный\r\nГодовое потребление энергии: 145 кВтч\r\nЦвет: серебристый",
//    Img = "https://holod.ru/pics/clean/medium/55/804155_1.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//    Name = "Beko B3RCNK362HW",
//    Type = context.ProductTypes.Where(x => x.Id == 1).Single(),
//    Price = 34990,
//    Description = "Размеры:\r\nвысота (см): 186\r\nширина (см): 59,5\r\nглубина (см): 65\r\n\r\nОбщий объем/ Полезный объем:\r\nХолодильника (л): 368/320\r\nХолодильной камеры (вкл. зону свежести) (л): -/220\r\nМорозильной камеры (л): -/100\r\n\r\nТип управления: электронный\r\nКласс энергопотребления: A+\r\nКлиматический класс: SN-T (от +10°С до +43°С)\r\nКоличество компрессоров: 1\r\nГодовое потребление энергии: 337 кВтч\r\nЦвет: белый",
//    Img = "https://holod.ru/pics/clean/medium/35/745435_0.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//    Name = "Blackton Bt VC1403C",
//    Type = context.ProductTypes.Where(x => x.Id == 2).Single(),
//    Price = 3799,
//    Description = "Мощность:\r\nПотребляемая мощность: 1400 Вт\r\nМощность всасывания: 350 Вт\r\n\r\nСистема фильтрации:\r\nОбъем пылесборника: 2 л\r\nЦиклонный фильтр\r\n\r\nНасадки:\r\nЩелевая насадка, комбинированная щетка для пола/ковра\r\n\r\nДополнительные данные:\r\nАвтоматическое сматывание шнура\r\nМакс. уровень шума, дБ: 78\r\nДлина шнура, м: 4\r\nМатериал трубки: Металл",
//    Img = "https://holod.ru/pics/clean/medium/15/903115_0.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//    Name = "Tefal TW4853EA",
//    Type = context.ProductTypes.Where(x => x.Id == 2).Single(),
//    Price = 12999,
//    Description = "Мощность:\r\nМощность, Вт: 550\r\n\r\nСистема фильтрации:\r\nЕмкость контейнера для пыли: 2.5 л\r\n3 уровня фильтрации: циклонный+угольный+высокоэффективный фильтры\r\nУровни фильтрации: 3\r\n\r\nНасадки:\r\nЩетки для пола: 2 позиции (SPA II)\r\nНасадка для паркета\r\nМини моторизованная щетка\r\nНасадка для обивки\r\n\r\nДополнительные данные:\r\nКлассическая рукоятка с системой легкой очистки (системой “Easy Brush“)\r\n1 колесико с поворотом на 360° + 2 больших задних колеса\r\nИндикатор максимального уровня пыли\r\nРукоятка для переноски\r\nТелескопическая (раздвижная) металлическая труба\r\nЭффективность уборки: 4-5\r\nУровень шума: 75 дБ\r\nВоздушный поток (см.куб./сек.): 24,2\r\nДавление (Кпа): 15,7 kPa\r\nДлина электрошнура: 6.2 м\r\nВ радиусе действия: 8.8 м",
//    Img = "https://holod.ru/pics/clean/medium/20/726220_1.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//    Name = "Dyson Gen5Detect Absolute",
//    Type = context.ProductTypes.Where(x => x.Id == 2).Single(),
//    Price = 115999,
//    Description = "Общие параметры:\r\nТип: пылесос\r\nВид: вертикальный/ручной\r\nОсновной цвет: синий\r\nДополнительные цвета: серый\r\n\r\nОсновные характеристики:\r\nБеспроводной\r\nОтсоединяемый ручной пылесос\r\nТип уборки: сухая\r\nТип пылесборника: контейнер\r\nФильтр тонкой очистки\r\nЕмкость пылесборника: 0.77 л\r\nРасположение пылесборника / мотора: сверху\r\nРегулятор мощности: на корпусе\r\nРадиус действия: не ограничен\r\nТруба всасывания: цельная\r\n\r\nПитание и производительность:\r\nПотребляемая мощность: 752 Вт\r\nМощность всасывания: 262 Вт\r\nТип питания: от аккумулятора\r\nНапряжение аккумулятора: 36 В\r\nТип аккумулятора: Li-Ion\r\nЕмкость аккумулятора: 2500 мА*ч\r\nМаксимальное время работы от аккумулятора: 70 мин\r\nМинимальное время работы от аккумулятора: 5 мин\r\nВремя зарядки: 270 мин\r\nКоличество аккумуляторов: 1 шт\r\n\r\nОсобенности:\r\nИнтеллектуальное распознавание частиц\r\nПьезо датчик\r\nТехнология защиты от наматывания волос\r\nУровень шума: 89 дБ\r\nЗащита от перегрева\r\n\r\nДополнительная информация:\r\nДлина сетевого шнура: 1.8 м\r\nМесто для хранения насадок\r\nГабариты: 127.6х25х27.6 см\r\nВес: 3.5 кг",
//    Img = "https://holod.ru/pics/clean/medium/95/1077795_0.jpg"
//});
//context.SaveChanges();

//context.Products.Add(new ProductDto()
//{
//    Name = "Kuppersberg FMW 250 X",
//    Type = context.ProductTypes.Where(x => x.Id == 3).Single(),
//    Price = 30790,
//    Description = "Особенности:\r\nПанель изготовлена из нержавеющей стали, а фурнитура выполнена также в серебристом цвете.\r\nОбъем камеры составляет 25 литров.\r\nПредусмотрено 10 уровней мощности и 8 автоматических программ.\r\nРазмораживание возможно как по весу, так и по времени. Внутренняя поверхность камеры выполнена из нержавеющей стали.\r\nПредусмотрена функция блокировки от детей.\r\nТаймер для удобного контроля времени приготовления.\r\n\r\nХарактеристики:\r\nВнутренний объем: 25 л\r\nВнутреннее покрытие камеры: нержавеющая сталь\r\nПоворотный стол\r\nТип дверцы: навесная\r\nТип открывания дверцы: ручка\r\nВид управления: электронное\r\nГриль\r\nДисплей\r\nЧасы\r\nОтсрочка старта\r\nЗащита от детей\r\nАвтоматическая разморозка\r\nМаксимальная мощность микроволн: 700 Вт",
//    Img = "https://holod.ru/pics/clean/medium/97/1059997_0.jpg"
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product= context.Products.Where(x => x.Id == 1).Single(),
//    Shop= context.Shops.Where(x => x.Id == 1).Single(),
//    Quantity=10
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 2).Single(),
//    Shop = context.Shops.Where(x => x.Id == 1).Single(),
//    Quantity = 3
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 3).Single(),
//    Shop = context.Shops.Where(x => x.Id == 1).Single(),
//    Quantity = 1
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 3).Single(),
//    Shop = context.Shops.Where(x => x.Id == 2).Single(),
//    Quantity = 2
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 4).Single(),
//    Shop = context.Shops.Where(x => x.Id == 3).Single(),
//    Quantity = 1
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 5).Single(),
//    Shop = context.Shops.Where(x => x.Id == 4).Single(),
//    Quantity = 1
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 6).Single(),
//    Shop = context.Shops.Where(x => x.Id == 2).Single(),
//    Quantity = 2
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 7).Single(),
//    Shop = context.Shops.Where(x => x.Id == 3).Single(),
//    Quantity = 1
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 8).Single(),
//    Shop = context.Shops.Where(x => x.Id == 4).Single(),
//    Quantity = 1
//});
//context.SaveChanges();

//context.Availability.Add(new AvailabilityDto()
//{
//    Product = context.Products.Where(x => x.Id == 9).Single(),
//    Shop = context.Shops.Where(x => x.Id == 2).Single(),
//    Quantity = 2
//});
//context.SaveChanges();

//var a=context.Users.ToList();

Console.WriteLine();

ProductTypeRepository productTypeRepository = new();

//var productTypes = productTypeRepository.GetAllProductTypes();

//Console.WriteLine();

ProductRepository productRepository = new();

//var products = productRepository.GetProductsByProductTypeId(2);

//Console.WriteLine();


ProductTypeClient productTypeClient = new();

//List<ProductTypeOutputModel> productTypes = productTypeClient.GetAllProductTypes();

//foreach (ProductTypeOutputModel i in productTypes)
//{
//	Console.WriteLine(i.Name);
//	Console.WriteLine(i.Img);
//}	

//Console.WriteLine();


ProductClient productClient = new();

//var products = productClient.GetAllProducts();

//var products = productClient.GetProductsByProductTypeId(1);

//var product = productClient.GetProductById(6);


Console.WriteLine();

UserClient userClient = new();

//var users = userClient.GetAllUsers();

//var products = productClient.GetProductsByProductTypeId(1);

AvailabilityClient availabilityClient = new();

//var availability = availabilityClient.GetAllAvailability();

//var c = availabilityClient.GetAvailabilityByProductId(1);

Console.WriteLine();