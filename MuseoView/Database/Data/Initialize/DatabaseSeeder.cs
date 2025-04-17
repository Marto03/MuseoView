using Database.Models;
using SQLite;

namespace Database.Data.Initialize
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(SQLiteAsyncConnection database)
        {
            await SeedCitiesAsync(database);
            await SeedRegionsAsync(database);
            await SeedMuseumsAsync(database);
        }

        private static async Task SeedCitiesAsync(SQLiteAsyncConnection database)
        {
            var citiesCount = await database.Table<CityModel>().CountAsync();
            if (citiesCount == 0)
            {
                var citiesForBlagoevgrad = new List<string>
                {
                    CityEnum.Благоевград.ToString(),
                    CityEnum.ГоцеДелчев.ToString(),
                    CityEnum.Разлог.ToString(),
                    CityEnum.Сандански.ToString(),
                    CityEnum.Петрич.ToString(),
                    CityEnum.Якоруда.ToString(),
                    CityEnum.Струмяни.ToString(),
                    CityEnum.Белица.ToString(),
                    CityEnum.Кресна.ToString(),
                    CityEnum.Симитли.ToString(),
                    CityEnum.Хаджидимово.ToString()
                };
                var citiesForBurgas = new List<string>
                {
                    CityEnum.Бургас.ToString(),
                    CityEnum.Българово.ToString(),
                    CityEnum.Каблешково.ToString(),
                    CityEnum.Камено.ToString(),
                    CityEnum.Карнобат.ToString(),
                    CityEnum.Китен.ToString(),
                    CityEnum.МалкоТърново.ToString(),
                    CityEnum.Несебър.ToString(),
                    CityEnum.Обзор.ToString(),
                    CityEnum.Поморие.ToString(),
                    CityEnum.Приморско.ToString(),
                    CityEnum.СветиВлас.ToString(),
                    CityEnum.Созопол.ToString(),
                    CityEnum.Средец.ToString(),
                    CityEnum.Сунгурларе.ToString(),
                    CityEnum.Царево.ToString(),
                    CityEnum.Черноморец.ToString(),
                    CityEnum.Айтос.ToString(),
                    CityEnum.Ахелой.ToString(),
                    CityEnum.Ахтопол.ToString()
                };
                var citiesForVarna = new List<string>
                {
                    CityEnum.Аксаково.ToString(),
                    CityEnum.Белослав.ToString(),
                    CityEnum.Бяла_Варна.ToString(),
                    CityEnum.Варна.ToString(),
                    CityEnum.ВълчиДол.ToString(),
                    CityEnum.Девня.ToString(),
                    CityEnum.ДолниЧифлик.ToString(),
                    CityEnum.Дългопол.ToString(),
                    CityEnum.Инатиево.ToString(),
                    CityEnum.Провадия.ToString(),
                    CityEnum.Суворово.ToString()
                };
                var citiesForVidin = new List<string>
                {
                    CityEnum.Белоградчик.ToString(),
                    CityEnum.Брегово.ToString(),
                    CityEnum.Видин.ToString(),
                    CityEnum.Грамада.ToString(),
                    CityEnum.Димово.ToString(),
                    CityEnum.Дунавци.ToString(),
                    CityEnum.Кула.ToString()
                };
                var citiesForVelikoTarnovo = new List<string>
                {
                    CityEnum.БялаЧерква.ToString(),
                    CityEnum.ВеликоТърново.ToString(),
                    CityEnum.Асеновец.ToString(),
                    CityEnum.ГорнаОряховица.ToString(),
                    CityEnum.Дебелец.ToString(),
                    CityEnum.ДолнаОряховица.ToString(),
                    CityEnum.Елена.ToString(),
                    CityEnum.Златарица.ToString(),
                    CityEnum.Килифарево.ToString(),
                    CityEnum.Лясковец.ToString(),
                    CityEnum.Павликени.ToString(),
                    CityEnum.ПолскиТръмбеш.ToString(),
                    CityEnum.Свищов.ToString(),
                    CityEnum.Стражица.ToString(),
                    CityEnum.Сухиндол.ToString()
                };
                var citiesForGabrovo = new List<string>
                {
                    CityEnum.Габрово.ToString(),
                    CityEnum.Дряново.ToString(),
                    CityEnum.Плачковци.ToString(),
                    CityEnum.Трявна.ToString(),
                    CityEnum.Севлиево.ToString()
                };
                var citiesForDobrich = new List<string>
                {
                    CityEnum.Балчик.ToString(),
                    CityEnum.ГенералТошево.ToString(),
                    CityEnum.Добрич.ToString(),
                    CityEnum.Каварна.ToString(),
                    CityEnum.Тервел.ToString(),
                    CityEnum.Шабла.ToString()
                };
                var citiesForKardzhali = new List<string>
                {
                    CityEnum.Ардино.ToString(),
                    CityEnum.Джебел.ToString(),
                    CityEnum.Крумовград.ToString(),
                    CityEnum.Кърджали.ToString(),
                    CityEnum.Момчилград.ToString()
                };
                var citiesForKyustendil = new List<string>
                {
                    CityEnum.БобовДол.ToString(),
                    CityEnum.Бобошево.ToString(),
                    CityEnum.Дупница.ToString(),
                    CityEnum.Кочериново.ToString(),
                    CityEnum.Кюстендил.ToString(),
                    CityEnum.Рила.ToString(),
                    CityEnum.СапареваБаня.ToString()
                };
                var citiesForLovech = new List<string>
                {
                    CityEnum.Априлци.ToString(),
                    CityEnum.Летница.ToString(),
                    CityEnum.Ловеч.ToString(),
                    CityEnum.Луковит.ToString(),
                    CityEnum.Тетевен.ToString(),
                    CityEnum.Троян.ToString(),
                    CityEnum.Угърчин.ToString(),
                    CityEnum.Ябланица.ToString()
                };
                var citiesForMontana = new List<string>
                {
                    CityEnum.Берковица.ToString(),
                    CityEnum.Бойчиновци.ToString(),
                    CityEnum.Брусарци.ToString(),
                    CityEnum.Бълчедръм.ToString(),
                    CityEnum.Вършец.ToString(),
                    CityEnum.Лом.ToString(),
                    CityEnum.Монтана.ToString(),
                    CityEnum.Чипровци.ToString()
                };
                var citiesForPazardzhik = new List<string>
                {
                    CityEnum.Батак.ToString(),
                    CityEnum.Белово.ToString(),
                    CityEnum.Брацигово.ToString(),
                    CityEnum.Велинград.ToString(),
                    CityEnum.Ветрен.ToString(),
                    CityEnum.Костандово.ToString(),
                    CityEnum.Пазарджик.ToString(),
                    CityEnum.Панагюрище.ToString(),
                    CityEnum.Пещера.ToString(),
                    CityEnum.Ракитово.ToString(),
                    CityEnum.Септември.ToString(),
                    CityEnum.Стрелча.ToString(),
                    CityEnum.Сърница.ToString()
                };
                var citiesForPernik = new List<string>
                {
                    CityEnum.Батановци.ToString(),
                    CityEnum.Брезник.ToString(),
                    CityEnum.Земен.ToString(),
                    CityEnum.Перник.ToString(),
                    CityEnum.Радомир.ToString(),
                    CityEnum.Трън.ToString()
                };
                var citiesForPleven = new List<string>
                {
                    CityEnum.Белене.ToString(),
                    CityEnum.Гулянци.ToString(),
                    CityEnum.ДолнаМитрополия.ToString(),
                    CityEnum.ДолниДъбник.ToString(),
                    CityEnum.Искър.ToString(),
                    CityEnum.Кнежа.ToString(),
                    CityEnum.Койнаре.ToString(),
                    CityEnum.Левски.ToString(),
                    CityEnum.Никопол.ToString(),
                    CityEnum.Плевен.ToString(),
                    CityEnum.Пордим.ToString(),
                    CityEnum.Славяново.ToString(),
                    CityEnum.Тръстеник.ToString(),
                    CityEnum.ЧервенБряг.ToString()
                };
                var citiesForPlovdiv = new List<string>
                {
                    CityEnum.Асеновград.ToString(),
                    CityEnum.Баня.ToString(),
                    CityEnum.Брезово.ToString(),
                    CityEnum.Калофер.ToString(),
                    CityEnum.Карлово.ToString(),
                    CityEnum.Клисура.ToString(),
                    CityEnum.Кричим.ToString(),
                    CityEnum.Куклен.ToString(),
                    CityEnum.Лъки.ToString(),
                    CityEnum.Перущица.ToString(),
                    CityEnum.Пловдив.ToString(),
                    CityEnum.Първомай.ToString(),
                    CityEnum.Раковски.ToString(),
                    CityEnum.Садово.ToString(),
                    CityEnum.Сопот.ToString(),
                    CityEnum.Стамболийски.ToString(),
                    CityEnum.Съединение.ToString(),
                    CityEnum.Хисаря.ToString()
                };
                var citiesForRazgrad = new List<string>
                {
                    CityEnum.Завет.ToString(),
                    CityEnum.Исперих.ToString(),
                    CityEnum.Кубрат.ToString(),
                    CityEnum.Лозница.ToString(),
                    CityEnum.Разград.ToString(),
                    CityEnum.ЦарКалоян.ToString()
                };
                var citiesForRuse = new List<string>
                {
                    CityEnum.Борово.ToString(),
                    CityEnum.Бяла_Русе.ToString(),
                    CityEnum.Ветово.ToString(),
                    CityEnum.Глоджево.ToString(),
                    CityEnum.ДвеМогили.ToString(),
                    CityEnum.Мартен.ToString(),
                    CityEnum.Русе.ToString(),
                    CityEnum.Сеново.ToString(),
                    CityEnum.СливоПоле.ToString()
                };
                var citiesForSilistra = new List<string>
                {
                    CityEnum.Алфатар.ToString(),
                    CityEnum.Главиница.ToString(),
                    CityEnum.Дулово.ToString(),
                    CityEnum.Силистра.ToString(),
                    CityEnum.Тутракан.ToString()
                };
                var citiesForSliven = new List<string>
                {
                    CityEnum.Кермен.ToString(),
                    CityEnum.Котел.ToString(),
                    CityEnum.НоваЗагора.ToString(),
                    CityEnum.Сливен.ToString(),
                    CityEnum.Твърдица.ToString(),
                    CityEnum.Шивачево.ToString()
                };
                var citiesForSmolyan = new List<string>
                {
                    CityEnum.Девин.ToString(),
                    CityEnum.Доспат.ToString(),
                    CityEnum.Златоград.ToString(),
                    CityEnum.Мадан.ToString(),
                    CityEnum.Неделино.ToString(),
                    CityEnum.Рудозем.ToString(),
                    CityEnum.Смолян.ToString(),
                    CityEnum.Чепеларе.ToString()
                };
                var citiesForSofiaCity = new List<string>
                {
                    CityEnum.Банкя.ToString(),
                    CityEnum.Бухово.ToString(),
                    CityEnum.НовиИскър.ToString(),
                    CityEnum.София.ToString()
                };
                var citiesForSofiaOblast = new List<string>
                {
                    CityEnum.Божурище.ToString(),
                    CityEnum.Ботевград.ToString(),
                    CityEnum.Годеч.ToString(),
                    CityEnum.ДолнаБаня.ToString(),
                    CityEnum.Драгоман.ToString(),
                    CityEnum.ЕлинПелин.ToString(),
                    CityEnum.Етрополе.ToString(),
                    CityEnum.Златица.ToString(),
                    CityEnum.Ихтиман.ToString(),
                    CityEnum.Копривщица.ToString(),
                    CityEnum.Костенец.ToString(),
                    CityEnum.Костинброд.ToString(),
                    CityEnum.МоминПроход.ToString(),
                    CityEnum.Пирдоп.ToString(),
                    CityEnum.Правец.ToString(),
                    CityEnum.Самоков.ToString(),
                    CityEnum.Своге.ToString(),
                    CityEnum.Сливница.ToString()
                };
                var citiesForStaraZagora = new List<string>
                {
                    CityEnum.Гурково.ToString(),
                    CityEnum.Гълъбово.ToString(),
                    CityEnum.Казанлък.ToString(),
                    CityEnum.Крън.ToString(),
                    CityEnum.Мъглиж.ToString(),
                    CityEnum.Николаево.ToString(),
                    CityEnum.ПавелБаня.ToString(),
                    CityEnum.Раднево.ToString(),
                    CityEnum.СтараЗагора.ToString(),
                    CityEnum.Чирпан.ToString(),
                    CityEnum.Шипка.ToString()
                };
                var citiesForTargovishte = new List<string>
                {
                    CityEnum.Антоново.ToString(),
                    CityEnum.Омуртаг.ToString(),
                    CityEnum.Опака.ToString(),
                    CityEnum.Попово.ToString(),
                    CityEnum.Търговище.ToString()
                };
                var citiesForHaskovo = new List<string>
                {
                    CityEnum.Димитровград.ToString(),
                    CityEnum.Ивайловград.ToString(),
                    CityEnum.Любимец.ToString(),
                    CityEnum.Маджарово.ToString(),
                    CityEnum.Меричплери.ToString(),
                    CityEnum.Свиленград.ToString(),
                    CityEnum.Симеоновград.ToString(),
                    CityEnum.Тополовград.ToString(),
                    CityEnum.Харванли.ToString(),
                    CityEnum.Хасково.ToString()
                };
                var citiesForShumen = new List<string>
                {
                    CityEnum.ВеликиПреслав.ToString(),
                    CityEnum.Върбица.ToString(),
                    CityEnum.Каолиново.ToString(),
                    CityEnum.Каспичан.ToString(),
                    CityEnum.НовиПазар.ToString(),
                    CityEnum.Плиска.ToString(),
                    CityEnum.Смядово.ToString(),
                    CityEnum.Шумен.ToString()
                };
                var citiesForYambol = new List<string>
                {
                    CityEnum.Болярово.ToString(),
                    CityEnum.Елхово.ToString(),
                    CityEnum.Стралджа.ToString(),
                    CityEnum.Ямбол.ToString()
                };

                var cityModels = new List<CityModel>();

                cityModels.AddRange(citiesForBlagoevgrad.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Благоевград
                }));

                cityModels.AddRange(citiesForBurgas.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Бургас
                }));

                cityModels.AddRange(citiesForVarna.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Варна
                }));

                cityModels.AddRange(citiesForVidin.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Видин
                }));

                cityModels.AddRange(citiesForVelikoTarnovo.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.ВеликоТърново
                }));

                cityModels.AddRange(citiesForGabrovo.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Габрово
                }));

                cityModels.AddRange(citiesForDobrich.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Добрич
                }));

                cityModels.AddRange(citiesForKardzhali.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Кърджали
                }));

                cityModels.AddRange(citiesForKyustendil.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Кюстендил
                }));

                cityModels.AddRange(citiesForLovech.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Ловеч
                }));

                cityModels.AddRange(citiesForMontana.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Монтана
                }));

                cityModels.AddRange(citiesForPazardzhik.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Пазарджик
                }));

                cityModels.AddRange(citiesForPernik.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Перник
                }));

                cityModels.AddRange(citiesForPleven.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Плевен
                }));

                cityModels.AddRange(citiesForPlovdiv.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Пловдив
                }));

                cityModels.AddRange(citiesForRazgrad.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Разград
                }));

                cityModels.AddRange(citiesForRuse.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Русе
                }));

                cityModels.AddRange(citiesForSilistra.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Силистра
                }));

                cityModels.AddRange(citiesForSliven.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Сливен
                }));

                cityModels.AddRange(citiesForSmolyan.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Смолян
                }));

                cityModels.AddRange(citiesForSofiaCity.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.СофияГрад
                }));

                cityModels.AddRange(citiesForSofiaOblast.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.СофияОбласт
                }));

                cityModels.AddRange(citiesForStaraZagora.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.СтараЗагора
                }));

                cityModels.AddRange(citiesForTargovishte.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Търговище
                }));

                cityModels.AddRange(citiesForHaskovo.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Хасково
                }));

                cityModels.AddRange(citiesForShumen.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Шумен
                }));

                cityModels.AddRange(citiesForYambol.Select(city => new CityModel
                {
                    Name = city,
                    RegionId = (int)RegionEnum.Ямбол
                }));

                await database.InsertAllAsync(cityModels);
            }
        }
        private static async Task SeedRegionsAsync(SQLiteAsyncConnection database)
        {
            //var regionsCount = await database.Table<RegionModel>().CountAsync();
            if (await database.Table<RegionModel>().CountAsync() == 0)
            {
                var regions = new List<RegionModel>
                {
                    new RegionModel { Name = RegionEnum.Благоевград.ToString() },
                    new RegionModel { Name = RegionEnum.Бургас.ToString() },
                    new RegionModel { Name = RegionEnum.Варна.ToString() },
                    new RegionModel { Name = RegionEnum.ВеликоТърново.ToString() },
                    new RegionModel { Name = RegionEnum.Видин.ToString() },
                    new RegionModel { Name = RegionEnum.Враца.ToString() },
                    new RegionModel { Name = RegionEnum.Габрово.ToString() },
                    new RegionModel { Name = RegionEnum.Добрич.ToString() },
                    new RegionModel { Name = RegionEnum.Кърджали.ToString() },
                    new RegionModel { Name = RegionEnum.Кюстендил.ToString() },
                    new RegionModel { Name = RegionEnum.Ловеч.ToString() },
                    new RegionModel { Name = RegionEnum.Монтана.ToString() },
                    new RegionModel { Name = RegionEnum.Пазарджик.ToString() },
                    new RegionModel { Name = RegionEnum.Перник.ToString() },
                    new RegionModel { Name = RegionEnum.Плевен.ToString() },
                    new RegionModel { Name = RegionEnum.Пловдив.ToString() },
                    new RegionModel { Name = RegionEnum.Разград.ToString() },
                    new RegionModel { Name = RegionEnum.Русе.ToString() },
                    new RegionModel { Name = RegionEnum.Силистра.ToString() },
                    new RegionModel { Name = RegionEnum.Сливен.ToString() },
                    new RegionModel { Name = RegionEnum.Смолян.ToString() },
                    new RegionModel { Name = RegionEnum.СофияГрад.ToString() },
                    new RegionModel { Name = RegionEnum.СофияОбласт.ToString() },
                    new RegionModel { Name = RegionEnum.СтараЗагора.ToString() },
                    new RegionModel { Name = RegionEnum.Търговище.ToString() },
                    new RegionModel { Name = RegionEnum.Хасково.ToString() },
                    new RegionModel { Name = RegionEnum.Шумен.ToString() },
                    new RegionModel { Name = RegionEnum.Ямбол.ToString() }

                    };

                await database.InsertAllAsync(regions);
            }
        }

        private static async Task SeedMuseumsAsync(SQLiteAsyncConnection database)
        {
            var museumsCount = await database.Table<MuseumModel>().CountAsync();
            if (museumsCount == 0)
            {
                var museums = new List<MuseumModel>
                {
                    #region Ямбол
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Ямбол",
                        RegionId = (int)RegionEnum.Ямбол,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = null,
                        Location = "гр. Ямбол, ул. „Бяло море“ №2",
                        OpeningHours = "понеделник – петък: 8:00 – 12:00 ч. и 13:00 – 17:00 ч.; в почивните дни (събота и неделя) се отваря след предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически резерват „Тракийски и античен град Кабиле“",
                        RegionId = (int)RegionEnum.Ямбол,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = null,
                        Location = "близо до гр. Ямбол",
                        OpeningHours = "1 април – 31 октомври: 8:00 – 18:30 ч.\n1 ноември – 31 март: 9:00 – 15:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на бойната слава",
                        RegionId = (int)RegionEnum.Ямбол,
                        TypeStatusId = (int)MuseumTypeEnum.Военно_исторически,
                        Description = null,
                        Location = "гр. Ямбол, ул. „Стара планина“ №1",
                        OpeningHours = "вторник – събота: 9:00 – 12:00 ч. и 13:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Културно-информационен център „Безистена“",
                        RegionId = (int)RegionEnum.Ямбол,
                        TypeStatusId = (int)MuseumTypeEnum.Интерактивен_музей_и_културен_център, // Интерактивен музей и културен център
                        Description = null,
                        Location = "гр. Ямбол",
                        OpeningHours = "информацията не е налична в предоставените източници"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографско-археологически музей – Елхово",
                        RegionId = (int)RegionEnum.Ямбол,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски_и_археологически_музей,
                        Description = null,
                        Location = "гр. Елхово",
                        OpeningHours = "информацията не е налична в предоставените източници"
                    },
                    #endregion
                    #region Сливен
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Сливен",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = null,
                        Location = "бул. „Цар Освободител“ №18, Сливен",
                        OpeningHours = "Лятно (1 април – 31 октомври): Вторник – Събота: 9:00 – 12:00 ч. и 14:00 – 17:00 ч.; Неделя и Понеделник: Почивни дни\n" +
                                       "Зимно (1 ноември – 31 март): Вторник – Събота: 9:00 – 12:00 ч. и 13:00 – 17:00 ч.; Неделя и Понеделник: Почивни дни\n" +
                                       "Бележка: За неделни посещения през зимния период е необходима предварителна заявка на телефон 0889 968 775 (главен екскурзовод)."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Хаджи Димитър“",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = null,
                        Location = "ул. „Асенова“ №2, Сливен",
                        OpeningHours = "9:00 – 12:00 ч. и 14:00 – 17:00 ч.; Почивни дни: Понеделник"
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Добри Чинтулов“",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = null,
                        Location = "ул. „Места“ №5, Сливен",
                        OpeningHours = "9:00 – 12:00 ч. и 14:00 – 17:00 ч.; Почивни дни: Събота и Неделя\n" +
                                       "Бележка: Посещения се осъществяват по заявка чрез екскурзовода в Къща музей „Сливенски бит“ (ул. „Симеон Табаков“ №5)."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Сливенски бит“",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = null,
                        Location = "ул. „Симеон Табаков“ №5, Сливен",
                        OpeningHours = "Вторник – Събота: 9:00 – 17:00 ч.; Почивни дни: Неделя и Понеделник"
                    },
                    new MuseumModel
                    {
                        Name = "Национален музей на текстилната индустрия",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Специализиран, // Специализиран музей
                        Description = null,
                        Location = "пл. „Стоил войвода“ №3, Сливен",
                        OpeningHours = "Понеделник – Петък: 8:30 – 16:30 ч.; Събота и Неделя: с предварителна заявка за групи над 10 души"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на авиацията в Крушаре",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Авиационен, // Музей на авиацията
                        Description = null,
                        Location = "село Крушаре, община Сливен",
                        OpeningHours = "по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на старините в село Желю Войвода",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически, // Археологически музей
                        Description = null,
                        Location = "село Желю Войвода, община Сливен",
                        OpeningHours = "по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на народните инструменти в село Стралджа",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = null,
                        Location = "село Стралджа, община Сливен",
                        OpeningHours = "по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на виното в село Войвода",
                        RegionId = (int)RegionEnum.Сливен,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски/Селски музей
                        Description = null,
                        Location = "село Войвода, община Сливен",
                        OpeningHours = "по предварителна заявка"
                    },
                    #endregion
                    #region Варна
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически, // Археологически музей
                        Description = "Музеят разполага с над 50 000 експоната, включително уникалния Варненски златен некропол, и представя историята на региона от праисторията до новото време.",
                        Location = "гр. Варна, бул. \"Мария Луиза\" №41",
                        OpeningHours = "Зимен сезон (октомври – април): 10:00 – 17:00 (почивни дни: неделя и понеделник)\n" +
                                       "Летен сезон (май – септември): 10:00 – 17:00 (отворен всеки ден)"
                    },
                    new MuseumModel
                    {
                        Name = "Природонаучен музей – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен, // Природонаучен музей
                        Description = "Музеят предлага експозиции на флората и фауната на Черноморския регион, както и редки и интересни природни образци.",
                        Location = "гр. Варна, бул. \"Мария Луиза\" №44",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на възраждането – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = "Посветен е на историческите събития и личности, свързани с Българското възраждане и развитието на Варна през този период.",
                        Location = "гр. Варна, ул. \"Стефан Караджа\" №1",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей за нова история на Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = "Представя развитието на Варна от края на XIX до средата на XX век, включително социални, икономически и културни аспекти.",
                        Location = "гр. Варна, бул. \"Сливница\" №2",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = "Експозициите включват традиционни български облекла, занаяти и битови предмети, отразяващи културното наследство на региона.",
                        Location = "гр. Варна, ул. \"Бачо Киро\" №19",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на образованието – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Образователен, // Образователен музей
                        Description = "Посветен е историята на образованието във Варна, с акцент върху развитието на училищата и педагогическите практики.",
                        Location = "гр. Варна, ул. \"Цар Симеон I\" №1",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на ретро автомобилите – Варна",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Автомобилен, // Автомобилен музей
                        Description = "Експозицията включва колекция от ретро автомобили и мотоциклети, отразяващи историята на автомобилната индустрия.",
                        Location = "гр. Варна, бул. \"Вл. Варненчик\" №186",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на пчеларството – с. Орешак",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = "Посветен е традициите и техниките на пчеларството в региона, с демонстрации и интерактивни изложби.",
                        Location = "с. Орешак, община Варна",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на рибарството – с. Каменар",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = null,
                        Location = "с. Каменар, община Варна",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на мозайките – Девня",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музеят представя уникални мозайки от римската епоха, открити при археологически разкопки в района.",
                        Location = "гр. Девня",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък), 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Общински културен институт /музей/ – Бяла",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = null,
                        Location = "гр. Бяла, ул. \"Андрей Премянов\" №14, пл. „Европа“",
                        OpeningHours = "09:00 – 17:00 (понеделник – петък); Почивни дни: събота и неделя"
                    },
                    new MuseumModel
                    {
                        Name = "Парк-музей \"Владислав Варненчик\"",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Парк-музеят е посветен на историческата битка при Варненчик и включва паметници и експозиции, отразяващи събитията от 1444 година.",
                        Location = "гр. Варна",
                        OpeningHours = "08:30 – 17:30 (понеделник – петък); Почивни дни: събота и неделя"
                    },
                    new MuseumModel
                    {
                        Name = "Римски терми",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Останки от римски бани, които предоставят информация за обществените и културни практики през римската епоха.",
                        Location = "гр. Варна",
                        OpeningHours = "10:00 – 18:00 (понеделник – петък); 10:00 – 14:00 (събота и неделя)"
                    },
                    new MuseumModel
                    {
                        Name = "Аладжа манастир",
                        RegionId = (int)RegionEnum.Варна,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически | (int)MuseumTypeEnum.Археологически,
                        Description = "Изсечен в скалите манастирски комплекс, датиращ от средновековието, с църква, килии и други помещения.",
                        Location = "гр. Варна",
                        OpeningHours = "09:00 – 18:00 (понеделник – неделя)"
                    },
                    #endregion
                    #region Бургас
                    new MuseumModel
                    {
                        Name = "Археологически музей – Бургас",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Представя археологическото наследство на региона от 6-ти до 15-ти век, включително находки от тракийската и римската епоха.",
                        Location = "ул. \"Алеко Богориди\" №21, Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Бургас",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Фокусира се върху новата история на града и региона, включително колекции от антики и икони.",
                        Location = "ул. \"Лермонтов\" №31, Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Бургас",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Представя традиционни български носии, текстил и занаятчийски изделия.",
                        Location = "ул. \"Славянска\" №69, Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Научен център \"Петя Дубарова\"",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Посветен на живота и творчеството на бургаската поетеса Петя Дубарова.",
                        Location = "ул. \"Цар Симеон\" №106, Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на солта – Поморие",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Музей_на_солта,
                        Description = "Демонстрира традициите и процесите свързани със солодобива в региона.",
                        Location = "ул. \"Княз Борис I\" №1, Поморие",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей – Несебър",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Съдържа експонати от античността и средновековието, отразяващи богатото историческо наследство на града.",
                        Location = "ул. \"Христо Кидев\" №2, Несебър",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Авиомузей Бургас",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Авиомузей,
                        Description = null,
                        Location = "Бургас, бивше военно летище",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Природонаучен музей – Бургас",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = null,
                        Location = "ул. „Александровска“ 26, 8000 Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Георги Баев“",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = null,
                        Location = "ул. „Георги Баев“ 1, 8000 Бургас",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей – Созопол",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = null,
                        Location = "ул. „Цар Симеон“ 2, 8130 Созопол",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Малко Търново",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = null,
                        Location = "ул. „Цар Освободител“ 1, 8460 Малко Търново",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Поморие",
                        RegionId = (int)RegionEnum.Бургас,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = null,
                        Location = "ул. „Княз Борис I“ 13, 8200 Поморие",
                        OpeningHours = "Понеделник - Петък: 09:00 - 18:00, Събота - Неделя: 10:00 - 18:00"
                    },
                    #endregion
                    #region Благоевград
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Благоевград",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = "Културен, научен и образователен институт, създаден през 1952 г., с експозиции, отразяващи хилядолетната история и култура на Пиринския край.",
                        Location = "гр. Благоевград, ул. 'Славянска' №1",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей на Георги Измирлиев – Македончето",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен, // Художествен музей
                        Description = "Посветена на живота и делото на Георги Измирлиев – Македончето, видна фигура в българската литература и революционно движение.",
                        Location = "гр. Благоевград, ул. 'Георги Измирлиев' №5",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:00"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографско-исторически музей – Баня",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски, // Етнографски музей
                        Description = "Отразява историята и етнографията на село Баня, с експозиции на традиционни носии, занаяти и битови предмети.",
                        Location = "с. Баня, община Разлог, ул. 'Цар Освободител' №12",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Гоце Делчев",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = "Представя историята на град Гоце Делчев и региона, с акцент върху националноосвободителните борби.",
                        Location = "гр. Гоце Делчев, ул. 'Гоце Делчев' №1",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Добринище",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически, // Исторически музей
                        Description = "Фокусира се върху историята и културата на Добринище и региона, с експозиции на археологически находки и етнографски материали.",
                        Location = "гр. Добринище, ул. 'Втора' №3",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:00"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на ретро автомобилите – Капатово",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Автомобилен, // Автомобилен музей
                        Description = "Колекция от ретро автомобили и мотоциклети, отразяващи историята на автомобилната индустрия в региона.",
                        Location = "с. Капатово, община Симитли, ул. 'Струма' №15",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей – Сандански",
                        RegionId = (int)RegionEnum.Благоевград,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически, // Археологически музей
                        Description = "Експозиции, включващи находки от античността и средновековието, отразяващи богатото историческо наследство на града.",
                        Location = "гр. Сандански, ул. 'Македония' №1",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    #endregion
                    #region Велико Търново
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Велико Търново",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Основният музей на региона, разположен в град Велико Търново, с филиали в Арбанаси, Никюп, махала Гърците и град Килифарево.",
                        Location = "гр. Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически резерват 'Никополис ад Иструм'",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Археологически обект край село Никюп, разкриващ останки от римския град Никополис ад Иструм.",
                        Location = "с. Никюп, община Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Архитектурно-музеен резерват 'Арбанаси'",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Архитектурен,
                        Description = "Исторически комплекс с добре запазена архитектура и множество църкви с ценни стенописи.",
                        Location = "с. Арбанаси, община Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски комплекс 'Осенарска река'",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Комплекс край село Вонеща вода, демонстриращ традиционния български бит и култура.",
                        Location = "с. Вонеща вода, община Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей 'Филип Тотю'",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Посветена на живота и делото на революционера Филип Тотю, разположена в село Вонеща вода.",
                        Location = "с. Вонеща вода, община Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Килифарево",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей в град Килифарево, отразяващ историята и културата на региона.",
                        Location = "гр. Килифарево, община Велико Търново",
                        OpeningHours = "Понеделник – Петък: 09:00 – 18:00, Събота – Неделя: 10:00 – 18:00"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на илюзиите – Велико Търново",
                        RegionId = (int)RegionEnum.ВеликоТърново,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Интерактивен музей, предлагащ различни оптични и научни илюзии за посетителите.",
                        Location = "гр. Велико Търново",
                        OpeningHours = "Понеделник – Петък: 10:00 – 19:00, Събота – Неделя: 11:00 – 20:00"
                    },
                    #endregion
                    #region Шумен
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Шумен",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, представящ богатата история и култура на региона.",
                        Location = "бул. „Славянски“ №17, гр. Шумен, 9700",
                        OpeningHours = "Лятно (април – октомври): 10:00 – 18:00 ч., без почивен ден; Зимно (ноември – март): 9:00 – 17:00 ч., почивни дни – събота и неделя",
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Панайот Волов“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, посветен на живота и делото на Панайот Волов. Музеят е част от структурата на Регионален исторически музей – Шумен и е най-старата запазена постройка в града.",
                        Location = "ул. „Цар Освободител“ №16, гр. Шумен",
                        OpeningHours = "Лятно работно време: 9:00 – 12:00 и 13:00 – 18:00 (април – октомври); Зимно работно време: 8:00 – 12:00 и 13:00 – 17:00 (ноември – март). За събота и неделя се изисква предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Лайош Кошут“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, посветен на унгарския революционер Лайош Кошут, който е живял в Шумен през 1849 г. Музеят е част от структурата на Регионален исторически музей – Шумен и е основан през 1949 г. в дома на хаджи Димитраки Хаджипанев, където Кошут е отсядал.",
                        Location = "ул. „Цар Освободител“ №115, гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музеен комплекс „Панчо Владигеров“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Музикален,
                        Description = "Музеен комплекс, посветен на живота и творчеството на великия български композитор Панчо Владигеров. Комплексът включва експозиции, свързани с музикалното наследство на Владигеров и неговия принос към световната музикална сцена. Тук могат да се видят много снимки и документи, свързани с композитора, както и възстановки на стаите от дома му, включително работния му кабинет и първото му пиано. Комплексът разполага и със самостоятелна експозиция 'Музикалното дело в Шумен' и камерна концертна зала, в която често се организират концерти.",
                        Location = "ул. „Цар Освободител“ №136, гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Ганкацки историко-археологически резерват „Шуменска крепост“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.АрхеологическиРезерват,
                        Description = "Историко-археологически резерват, разположен на хълма Хисарлъка край град Шумен. Крепостта е една от най-значимите археологически находки в България и предоставя ценна информация за развитието на региона през различни исторически периоди. В рамките на резервата могат да се видят останки от древни стени, кули и други архитектурни елементи, които свидетелстват за богатото историческо наследство на района. Работното време на резервата е от понеделник до петък между 9:00 и 17:00 часа, а входната такса е 3 лева. Предлагат се и беседи срещу заплащане от 10 лева.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; няма почивни дни",
                    },
                    new MuseumModel
                    {
                        Name = "Национален историко-археологически резерват „Мадара“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.АрхеологическиРезерват,
                        Description = "Национален историко-археологически резерват, разположен близо до село Мадара, община Шумен. Резерватът е известен с уникалния скален релеф на Мадарския конник, който е включен в списъка на световното културно наследство на ЮНЕСКО. Мястото предлага множество археологически находки и паметници, които свидетелстват за богатата история на региона. Работното време на резервата е от понеделник до петък между 8:30 и 17:00 часа, а входната такса е 6 лева. Предлагат се и беседи срещу заплащане от 10 лева.",
                        Location = "с. Мадара, община Шумен",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; без почивен ден",
                    },
                    new MuseumModel
                    {
                        Name = "Национален историко-археологически резерват „Плиска“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.АрхеологическиРезерват,
                        Description = "Национален историко-археологически резерват, разположен на 28 километра североизточно от град Шумен и на 3 километра от съвременния град Плиска. Резерватът е мястото, където се намират останките на първата българска столица, създадена през 681 година. Плиска е била един от най-големите и богати градове в света по онова време. Архитектурата на столицата е съчетание от тракийски, славянски и прабългарски мотиви. Тук могат да се видят руини от дворци, църкви и други значими сгради от периода на Първото българско царство. Работното време на резервата варира според сезона: лятно работно време (май – октомври) е от 8:30 до 19:00 часа без почивен ден, а зимно работно време (ноември – април) е от 8:30 до 17:00 часа с почивен ден на 1 януари. Входната такса е 5 лева, а беседите се предлагат срещу заплащане от 10 лева.",
                        Location = "гр. Плиска, област Шумен",
                        OpeningHours = "Лятно работно време (май – октомври): 8:30 – 19:00 ч. (без почивен ден); Зимно работно време (ноември – април): 8:30 – 17:00 ч. (почивен ден: 1 януари)",
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Добри Войников“",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, посветен на Добри Войников, виден български възрожденец, учител, автор на учебници, музикант, участник в Първия български оркестър от 1850 г., композитор, пръв български диригент и музикален критик, читалищен деец, драматург, театрал и автор на първата българска драма („Стоян войвода“). Роден в Шумен през 1833 г., той е автор на първата българска комедия „Криворазбраната цивилизация“. Къщата музей е открита през 1953 г. и съдържа експозиции, свързани с живота и творчеството на Войников. Тук могат да се видят оригинални ръкописи, книги и лични вещи на писателя. Работното време на музея е от понеделник до петък между 9:00 и 17:00 часа, а почивните дни са събота и неделя.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; почивни дни – събота и неделя"
                    },
                    new MuseumModel
                    {
                        Name = "Часовниковата кула",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.ИсторическиПаметник,
                        Description = "Исторически паметник, представляващ часовникова кула, построена през 18 век. Кулата е символ на град Шумен и е една от най-старите и известни забележителности в града. Тя е висока около 25 метра и е иззидана от речен камък. Въпреки че няма циферблат, тя отмерва времето с камбанен звън на всеки 15 минути. Кулата е построена от българи, дошли от Македония, а средствата за изграждането ѝ са осигурени от местните заможни еснафи. Разположена е в някогашната махала Ортамахале в старата част на града, където е имало и джамия, която вече не съществува. Работното време на кулата е от понеделник до петък между 8:30 и 12:00 часа и от 13:00 до 17:00 часа.",
                        Location = "ул. „Цар Самуил“, гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 8:30 – 12:00 и 13:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Шуменския гарнизон",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Военен,
                        Description = "Военен музей, посветен на историята на Шуменския гарнизон и военните традиции в региона. Музеят е разположен в сградата на бившия щаб на гарнизона и съдържа експозиции, свързани с военната история на Шумен и България. Тук могат да се видят униформи, оръжия, медали и други артефакти, свързани с военните действия и героите от региона. Музеят е част от структурата на Министерството на отбраната и предлага образователни програми и обиколки с екскурзовод. Работното време на музея е от понеделник до петък между 9:00 и 17:00 часа, а за събота и неделя се изисква предварителна заявка.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Експозиция на военна техника",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Военен,
                        Description = "Експозиция на военна техника, разположена в гр. Шумен, която представя разнообразие от военни машини и оборудване от различни исторически периоди. Експозицията включва танкове, артилерийски оръдия, бронетранспортьори и други военни превозни средства, използвани от българската армия. Тази колекция е предназначена да покаже развитието на военната технология и стратегия през годините. Експозицията е част от структурите на Министерството на отбраната и предлага образователни програми и обиколки с екскурзовод. Работното време на експозицията е от понеделник до петък между 9:00 и 17:00 часа, а за събота и неделя се изисква предварителна заявка.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Национален историко-археологически резерват „Велики Преслав”",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Национален историко-археологически резерват „Велики Преслав” е разположен в близост до съвременния град Велики Преслав, който е бил столица на България през 9-10 век. Резерватът включва археологическите разкопки на старата столица и важни исторически паметници, които свидетелстват за значението на този град в българската история. В музея се съхраняват артефакти, които предоставят ценна информация за живота през Средновековието и за културното наследство на региона.",
                        Location = "гр. Велики Преслав, община Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; почивни дни – събота и неделя"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на коня",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей на коня в Шумен е уникален музей, посветен на конете и тяхната роля в българската култура и история. Музеят предлага експозиции, които показват важността на конете в традиционния живот на българите, както и разнообразието от конни породи и техните характеристики. Той е чудесно място за любителите на животни и етнография, които искат да се запознаят с културното наследство, свързано с конете.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Съединението",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей на Съединението в Шумен е посветен на историческите събития, свързани с обединението на Източна Румелия с Княжество България през 1885 година. Музеят предлага подробен поглед върху процеса на съединение, неговите основни личности и значението му за съвременната българска история. Експозициите включват документи, снимки и предмети от времето на съединението, които разказват за решаващия момент в развитието на българската държава.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Планетариум",
                        RegionId = (int)RegionEnum.Шумен,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Планетариумът в Шумен предлага уникална възможност да се запознаете с вселената, звездите, планетите и астрономията. Музеят организира интерактивни лекции и демонстрации за наблюдение на небесни тела, като целта му е да вдъхновява и образова посетителите в областта на науката и космоса. Експозициите включват модели на планети, астрономически прибори и интерактивни технологии, които дават възможност за потапяне в мистериите на Вселената.",
                        Location = "гр. Шумен",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; за събота и неделя се изисква предварителна заявка"
                    },
                    #endregion
                    #region Видин
                    new MuseumModel
                    {
                        Name = "Крепост „Баба Вида“",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Единствената изцяло запазена средновековна крепост в България, превърната в музей.",
                        Location = "гр. Видин",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей Кула",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей,展示ващ археологически находки от района около град Кула, включително римски и тракийски артефакти.",
                        Location = "гр. Кула, ул. \"Христо Ботев\" №4",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей „Конака“",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ богатата история на региона от Античността до Руско-турската освободителна война.",
                        Location = "гр. Видин, ул. „Общинска“ №2",
                        OpeningHours = "Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 17:00 ч.; Събота и неделя: 9:30 – 17:00 ч. (лятно); 10:00 – 17:00 ч. (зимно)"
                    },
                    new MuseumModel
                    {
                        Name = "Музей „Кръстата казарма“",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, разположен в уникална сграда с кръстообразна форма, представящ етнографското наследство на региона.",
                        Location = "гр. Видин",
                        OpeningHours = "Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 17:00 ч.; Събота и неделя: 9:30 – 17:00 ч. (лятно); 10:00 – 17:00 ч. (зимно)"
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей – Епиграфски център",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей, специализиран в съхранението и представянето на епиграфски паметници и археологически находки от региона.",
                        Location = "гр. Видин",
                        OpeningHours = "Лятно: Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 17:00 ч.; Събота и неделя: 9:30 – 17:00 ч.; Зимно: Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 17:00 ч.; Събота и неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Художествена галерия „Никола Петров“",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Галерия, носеща името на известния български художник Никола Петров, представяща разнообразни художествени експозиции.",
                        Location = "гр. Видин",
                        OpeningHours = "Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 17:00 ч.; Събота: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Белоградчик",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ историята и културата на Белоградчик и региона.",
                        Location = "гр. Белоградчик, ул. „Капитан Кръстьо“ №1",
                        OpeningHours = "Лятно (01.04 – 31.10): Понеделник – Петък: 9:00 – 12:00 ч.; 13:00 – 18:00 ч.; Зимно (01.11 – 31.03): Понеделник – Петък: 8:30 – 12:00 ч.; 12:30 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Пещера „Магура“",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Една от най-големите пещери в България, известна със своите праисторически скални рисунки.",
                        Location = "с. Рабиша",
                        OpeningHours = "Понеделник – Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Белоградчишка крепост",
                        RegionId = (int)RegionEnum.Видин,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Историческа крепост, разположена сред уникалните Белоградчишки скали.",
                        Location = "гр. Белоградчик",
                        OpeningHours = "Понеделник – Неделя: 9:00 – 18:00 ч."
                    },
                    #endregion
                    #region Хасково
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Хасково",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Регионален исторически музей – Хасково е важен културен център, който събира, съхранява и излага артефакти, свързани с историята на региона. Музеят представя разнообразни експозиции, които обхващат археология, етнография, възраждане и нова история, както и природното богатство на Хасковския край.",
                        Location = "пл. 'Свобода' №19, гр. Хасково",
                        OpeningHours = "Летен период (април – октомври):\nВторник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:00 – 16:00 ч.\nЗимен период (ноември – март):\nВторник – Петък: 9:00 – 17:00 ч.\nСъбота: 10:00 – 16:00 ч.\nНеделя и понеделник: почивни дни"
                    },

                    new MuseumModel
                    {
                        Name = "Музеен център „Тракийско изкуство в Източните Родопи“",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музеен център „Тракийско изкуство в Източните Родопи“ е специализиран музей, посветен на археологическите находки и културното наследство на траките в региона на Източните Родопи. Музеят предлага уникални експозиции, които включват предмети и артефакти от тракийската цивилизация, открити в района, както и информация за историята, изкуството и обичаите на тракийските народи.",
                        Location = "с. Александрово, община Хасково",
                        OpeningHours = "Летен период (април – октомври):\nВторник – Неделя: 10:00 – 18:00 ч.\nЗимен период (ноември – март):\nВторник – Неделя: 9:00 – 17:00 ч.\nПонеделник: почивен ден"
                    },

                    new MuseumModel
                    {
                        Name = "Исторически музей – Харманли",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей – Харманли представя богатото културно и историческо наследство на града и региона. Музеят включва експозиции, които обхващат археология, етнография и нова история на Харманли и околните райони, предоставяйки ценна информация за развитието на региона през различни исторически етапи.",
                        Location = "гр. Харманли",
                        OpeningHours = "Понеделник – Петък: 8:00 – 17:00 ч. (обедна почивка: 12:00 – 13:00 ч.)"
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Паскалева къща“",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Къща-музей „Паскалева къща“ е етнографски музей, посветен на бита и културата на българите от региона на Хасково. Музеят се намира в историческа къща, в която се запазват автентични предмети, мебели и облекла, които илюстрират ежедневието и традициите на хората в миналото. Експозицията дава възможност на посетителите да се запознаят с обичаите, работата и начините на живот на местните хора.",
                        Location = "гр. Хасково",
                        OpeningHours = "Летен период (април – октомври):\nВторник – Петък: 10:00 – 18:00 ч.\nСъбота: 10:00 – 17:00 ч.\nЗимен период (ноември – март):\nВторник – Петък: 9:00 – 17:00 ч.\nСъбота: 10:00 – 16:00 ч.\nНеделя и понеделник: почивни дни"
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Шишманова къща“",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Къща-музей „Шишманова къща“ е етнографски музей, който пресъздава бита и традициите на хората от региона на Хасково. Музеят е разположен в историческа сграда, която е част от културното наследство на града. Експозицията включва автентични предмети от домакинството, облекла и инструменти, характерни за региона, като предоставя на посетителите уникална възможност да се запознаят с традициите и културата на местните хора.",
                        Location = "гр. Хасково",
                        OpeningHours = "Летен период (април – октомври):\nВторник – Петък: 10:00 – 18:00 ч.\nСъбота: 10:00 – 17:00 ч.\nЗимен период (ноември – март):\nВторник – Петък: 9:00 – 17:00 ч.\nСъбота: 10:00 – 16:00 ч.\nНеделя и понеделник: почивни дни"
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Кирковото училище“",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Къща-музей „Кирковото училище“ е исторически музей, посветен на образователната история и традиции в региона на Хасково. Музеят е разположен в бившото Кирково училище, което е едно от първите учебни заведения в района. Експозицията представя документи, снимки и предмети, свързани с развитието на образованието и културата в Хасково през различните исторически периоди.",
                        Location = "гр. Хасково",
                        OpeningHours = "Летен период (април – октомври):\nВторник – Петък: 10:00 – 18:00 ч.\nСъбота: 10:00 – 17:00 ч.\nЗимен период (ноември – март):\nВторник – Петък: 9:00 – 17:00 ч.\nСъбота: 10:00 – 16:00 ч.\nНеделя и понеделник: почивни дни"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на авиацията – Крумово",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Технически,
                        Description = "Музей на авиацията – Крумово е специализиран технически музей, който представя историята на българската авиация и развитието на авиационната техника. Музеят разполага с уникални експонати, включително самолети, хеликоптери и авиационни двигатели, които илюстрират етапите на развитие на авиационната индустрия в България. Той е ценен източник на знания за авиационните технологии и достижения.",
                        Location = "с. Крумово, община Хасково",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и неделя: по предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Историко-археологически резерват „Крайна“",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.АрхеологическиРезерват,
                        Description = "Историко-археологически резерват „Крайна“ е важен археологически обект, разположен в село Крайна, който обхваща останки от различни исторически епохи. Резерватът предлага уникални възможности за изследване на археологически находки и културни слоеве, свързани с развитието на човешките цивилизации в региона. Мястото е и значимо за научни изследвания и туристи, които се интересуват от археология и история.",
                        Location = "с. Крайна, община Хасково",
                        OpeningHours = "Целогодишно, но по предварителна уговорка за групи"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на минералните води",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музей на минералните води в Хасково е уникален музей, посветен на историята и значението на минералните води в региона. Музеят разказва за геоложките процеси, които формират минералните извори, както и тяхната роля в културата, медицината и туризма. Експозициите включват информация за минералните извори в района и тяхното значение за местното население и развитието на курорта.",
                        Location = "гр. Хасково, Парк „Минерални бани”",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и неделя: по уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на съвременното изкуство",
                        RegionId = (int)RegionEnum.Хасково,
                        TypeStatusId = (int)MuseumTypeEnum.Изкуствоведски,
                        Description = "Музей на съвременното изкуство в Хасково предлага уникална колекция от произведения на съвременното изкуство, включваща живопис, скулптура, фотография и други форми на изкуство. Музеят е посветен на развитието на съвременното изкуство и неговото място в съвременното общество. Експозициите са динамични и разнообразни, с акцент върху новаторски и иновативни произведения от български и чуждестранни художници.",
                        Location = "гр. Хасково",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.; събота и неделя по уговорка"
                    },
                    #endregion
                    #region Враца
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Враца",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ богатата история и културно наследство на Враца и региона, включително тракийското съкровище.",
                        Location = "гр. Враца, пл. „Христо Ботев” №2",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота, неделя и официални празници: 9:00 – 12:00 ч. и 13:00 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографско-възрожденски комплекс „Св. Софроний Врачански”",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Комплекс, включващ къщи-музеи и експозиции, отразяващи етнографското и възрожденско наследство на региона.",
                        Location = "гр. Враца, ул. „Софроний Врачански” №13",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота, неделя и официални празници: 9:00 – 12:00 ч. и 13:00 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Художествена галерия „Иван Фунев”",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Галерия, представяща произведения на изкуството от местни и национални художници.",
                        Location = "гр. Враца, пл. „Христо Ботев” №2",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота, неделя и официални празници: 9:00 – 12:00 ч. и 13:00 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на файтоните",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, представящ различни модели файтони и тяхната история.",
                        Location = "гр. Враца, ул. „Софроний Врачански” №13",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота и неделя: 10:00 – 14:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Природозащитен център „Натура“",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Център, посветен на опазването на природата и биоразнообразието в региона.",
                        Location = "гр. Враца, ул. „Поп Сава Катрафилов” №27",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота и неделя: 10:00 – 14:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Иван Замбин“",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, посветен на живота и делото на Иван Замбин, виден общественик и революционер.",
                        Location = "гр. Враца, ул. „Иван Замбин” №5",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч.; Събота и неделя: 10:00 – 14:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически комплекс „Калето“",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Археологически обект с останки от древни крепости и селища.",
                        Location = "гр. Мездра, ул. „Калето” №1",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Кораб-музей „Радецки“",
                        RegionId = (int)RegionEnum.Враца,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей на вода, представящ историята на кораба „Радецки“ и неговото участие в Априлското въстание.",
                        Location = "гр. Козлодуй, Пристанище Козлодуй",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 17:00 ч."
                    },
                    #endregion
                    #region Търговище
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Търговище",
                        RegionId = (int)RegionEnum.Търговище,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Регионален исторически музей – Търговище е важен културен институт, който събира и съхранява исторически артефакти, свързани с развитието на региона. Музеят предлага разнообразни експозиции, включително археологически находки, етнографски предмети и документи, които разказват за историята на Търговище и околните райони.",
                        Location = "бул. „Митрополит Андрей“ №2, гр. Търговище 7700",
                        OpeningHours = "Май – Септември:\nПонеделник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:30 – 16:00 ч.\nНеделя: 9:30 – 13:00 ч.\nОктомври – Април:\nПонеделник: 13:30 – 17:30 ч.\nВторник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:30 – 16:00 ч.\nНеделя: почивен ден"
                    },

                    new MuseumModel
                    {
                        Name = "Художествена галерия „Никола Маринов“",
                        RegionId = (int)RegionEnum.Търговище,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Художествена галерия „Никола Маринов“ в Търговище е културен център, който събира и представя произведения на изкуството от български и чуждестранни художници. Галерията носи името на известния български художник Никола Маринов и предлага разнообразие от изложби, включително живопис, графика и скулптура. Това е място, където любителите на изкуството могат да се насладят на произведения, които отразяват богатото културно наследство на региона.",
                        Location = "ул. „Мургаш“ №21, гр. Търговище 7700",
                        OpeningHours = "Понеделник – Петък: 8:30 – 12:00 ч. и 13:30 – 17:30 ч.;\nСъбота: 9:30 – 13:00 ч.;\nНеделя: почивен ден"
                    },

                    new MuseumModel
                    {
                        Name = "Славейковото училище",
                        RegionId = (int)RegionEnum.Търговище,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Славейковото училище е едно от първите светски училища в България, основано през 1866 г. В него се е обучавал и Петко Славейков. Днес сградата е музей, в който се експонират учебници, документи и лични вещи, отразяващи развитието на образованието в региона. Музеят разказва историята на образованието и културата, като подчертава важността на училището в културния и интелектуален живот на България.",
                        Location = "ул. „Славейков“ №1, гр. Търговище 7700",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:30 – 16:00 ч.\nНеделя: 9:30 – 13:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Никола Симов-Куруто“",
                        RegionId = (int)RegionEnum.Търговище,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Къщата е посветена на живота и делото на Никола Симов-Куруто, виден български революционер и знаменосец на Ботевата чета. В музея се съхраняват документи, снимки и лични вещи, отразяващи неговата революционна дейност. Музеят предоставя на посетителите възможността да се запознаят с важен период от българската история и да научат повече за героизма и приноса на Никола Симов-Куруто за националната борба за свобода.",
                        Location = "ул. „Ген. Гурко“ №5, гр. Търговище 7700",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:30 – 16:00 ч.\nНеделя: 9:30 – 13:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Етнографска експозиция в Хаджи-Ангеловата къща",
                        RegionId = (int)RegionEnum.Търговище,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Хаджи-Ангеловата къща е построена през 1863 г. и е една от най-представителните възрожденски жилищни сгради в града. В нея е разположена етнографската експозиция на музея, където се展示рат традиционни български облекла, домакински предмети и занаятчийски инструменти, отразяващи бита и културата на региона. Експозицията дава ценна информация за начина на живот на хората през възрожденския период.",
                        Location = "ул. „Хаджи Димитър“ №3, гр. Търговище 7700",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.\nСъбота: 9:30 – 16:00 ч.\nНеделя: 9:30 – 13:00 ч."
                    },
                    #endregion
                    #region Габрово
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Габрово",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ историята и културното наследство на Габрово и региона.",
                        Location = "ул. „Николаевска“ №10, гр. Габрово",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 17:30 ч. (последна обиколка в 16:45 ч.)"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей на открито „Етър“",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей на открито, показващ българската възрожденска архитектура, занаяти и обичаи.",
                        Location = "ул. „Генерал Дерожински“ №144, гр. Габрово",
                        OpeningHours = "Летен сезон (края на април – края на септември): 09:00 – 19:00 ч.; Зимен сезон (началото на октомври – края на април): 09:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Дом на хумора и сатирата",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Специализиран,
                        Description = "Музей, посветен на хумора и сатирата, известен като „Лувър на смеха“.",
                        Location = "ул. „Брянска“ №68, гр. Габрово",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музеен обект „Дечкова къща“",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Етнографски обект, представящ градския бит от края на XIX и началото на XX век.",
                        Location = "ул. „Опълченска“ №8, гр. Габрово",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч. (зимен сезон)"
                    },
                    new MuseumModel
                    {
                        Name = "Архитектурно-исторически резерват „Боженци“",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Архитектурен,
                        Description = "Село-музей, запазило възрожденската архитектура и традиции.",
                        Location = "с. Боженци, общ. Габрово",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Специализиран музей за резбарско и зографско изкуство – Трявна",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Музей, посветен на тревненската школа по дърворезба и иконопис.",
                        Location = "пл. „Капитан Дядо Никола“ №1, гр. Трявна",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Петко и Пенчо Славейкови“",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей, посветен на живота и творчеството на Петко и Пенчо Славейкови.",
                        Location = "ул. „Славейков“ №1, гр. Трявна",
                        OpeningHours = "Понеделник – Неделя: 09:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Рачо Стоянов“",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей, посветен на живота и творчеството на писателя Рачо Стоянов.",
                        Location = "ул. „Рачо Стоянов“ №5, гр. Габрово",
                        OpeningHours = "Понеделник – Петък: 09:00 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Интерактивен музей на индустрията",
                        RegionId = (int)RegionEnum.Габрово,
                        TypeStatusId = (int)MuseumTypeEnum.Технически,
                        Description = "Музей, представящ индустриалното развитие на Габрово чрез интерактивни експозиции.",
                        Location = "ул. „Николаевска“ №3, гр. Габрово",
                        OpeningHours = "От вторник до неделя: 09:00 – 18:30 ч. (последна обиколка в 17:00 ч.)"
                    },
                    #endregion
                    #region Добрич
                    new MuseumModel
                    {
                        Name = "Исторически музей – Балчик",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, представящ богатото културно наследство на Балчик и околностите му.",
                        Location = "пл. „21 септември“ №1, гр. Балчик",
                        OpeningHours = "Лятно работно време (май – септември): Понеделник – Неделя: 9:00 – 18:00 ч.; Зимно работно време (октомври – април): Понеделник – Петък: 8:00 – 12:00 и 13:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографска къща – Балчик",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Етнографски музей, представящ традиционния бит и култура на добруджанци.",
                        Location = "ул. „Ивайло“ №1, гр. Балчик",
                        OpeningHours = "Лятно работно време (май – септември): Понеделник – Неделя: 9:00 – 18:00 ч.; Зимно работно време (октомври – април): Понеделник – Петък: 8:00 – 12:00 и 13:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Културен център „Двореца“ – Балчик",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Бившата лятна резиденция на румънската кралица Мария, днес културен център и музей.",
                        Location = "ул. „Ак. Даки Йорданов“ №1, гр. Балчик",
                        OpeningHours = "Всеки ден: 8:30 – 20:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Природонаучен музей – Калиакра",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музей, посветен на уникалната природа на нос Калиакра и Черноморското крайбрежие.",
                        Location = "Нос Калиакра, общ. Каварна",
                        OpeningHours = "Всеки ден: 9:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Каварна",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, представящ археологическото и историческото наследство на Каварна.",
                        Location = "ул. „България“ №47, гр. Каварна",
                        OpeningHours = "Лятно работно време (май – септември): Понеделник – Неделя: 9:00 – 18:00 ч.; Зимно работно време (октомври – април): Понеделник – Петък: 8:00 – 12:00 и 13:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографска къща – Каварна",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Етнографски музей, представящ традиционния бит и култура на добруджанци.",
                        Location = "ул. „България“ №43, гр. Каварна",
                        OpeningHours = "Лятно работно време (май – септември): Понеделник – Неделя: 9:00 – 18:00 ч.; Зимно работно време (октомври – април): Понеделник – Петък: 8:00 – 12:00 и 13:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически резерват „Яйлата“",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Археологически резерват, включващ древни пещерни жилища, крепост и некрополи.",
                        Location = "с. Камен бряг, общ. Каварна",
                        OpeningHours = "Всеки ден: 9:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Добрич",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ историята и културното наследство на Добруджа.",
                        Location = "ул. „Д-р Константин Стоилов“ №18, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – събота: 9:00 – 13:00 и 14:00 – 18:00 ч.; Зимно работно време (октомври – април): понеделник – петък: 8:30 – 12:30 и 13:30 – 17:30 ч.; събота и неделя – по заявка за групи."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографска къща",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, представящ традиционния бит и култура на добруджанци.",
                        Location = "ул. „Ален мак“ №5, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – събота: 9:00 – 13:00 и 14:00 – 18:00 ч., неделя по заявка; Зимно работно време (октомври – април): понеделник – петък: 8:30 – 12:30 и 13:30 – 17:30 ч.; събота и неделя – по заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Художествена галерия Добрич – зала Възраждане",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Галерия, представяща българско изобразително изкуство от Възраждането до наши дни.",
                        Location = "ул. „България“ №14, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – събота: 9:00 – 12:30 и 13:30 – 18:00 ч.; Зимно работно време (октомври – април): понеделник – петък: 9:00 – 12:30 и 13:30 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей в градски парк „Свети Георги“",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, разположен в градския парк, представящ природното и културно наследство на региона.",
                        Location = "бул. „Трети март“ №1, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – събота: 9:00 – 13:00 и 14:00 – 18:00 ч., неделя по заявка; Зимно работно време (октомври – април): понеделник – петък: 8:30 – 12:30 и 13:30 – 17:30 ч.; събота и неделя – по заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Военно гробище музей",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, посветен на паметта на загиналите във войните, разположен на мястото на военно гробище.",
                        Location = "бул. „25-ти септември“ №53, гр. Добрич",
                        OpeningHours = "Посещенията са само по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Йордан Йовков“",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей, посветен на живота и творчеството на българския писател Йордан Йовков.",
                        Location = "ул. „Майор Векилски“ №18, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – неделя: 9:00 – 13:00 и 14:00 – 18:00 ч.; Зимно работно време (октомври – април): понеделник – петък: 8:30 – 12:30 и 13:30 – 17:30 ч.; събота и неделя – по заявка. Забележка: За да посетите къщата, трябва да отидете в Дом-паметник „Йордан Йовков“ на ул. „Ген. Гурко“ №4."
                    },
                    new MuseumModel
                    {
                        Name = "Дом-паметник „Йордан Йовков“",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей, посветен на живота и творчеството на Йордан Йовков, един от 100-те национални туристически обекта.",
                        Location = "ул. „Ген. Гурко“ №4, гр. Добрич",
                        OpeningHours = "Лятно работно време (май – септември): понеделник – неделя: 9:00 – 13:00 и 14:00 – 18:00 ч.; Зимно работно време (октомври – април): понеделник – петък: 8:30 – 12:30 и 13:30 – 17:30 ч.; събота и неделя – по заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Генерал Тошево",
                        RegionId = (int)RegionEnum.Добрич,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ историята и културното наследство на община Генерал Тошево.",
                        Location = "ул. „Васил Априлов“ №5, гр. Генерал Тошево",
                        OpeningHours = "Понеделник – Петък: 8:00 – 12:00 и 13:00 – 17:00; Събота и неделя – с предварителна заявка."
                    },
                    #endregion
                    #region Стара Загора
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Стара Загора",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Регионален исторически музей – Стара Загора съхранява и представя богатото културно и историческо наследство на региона. Музеят предлага разнообразни експозиции, включващи археологически находки, етнографски експонати и документи, свързани с историята на Стара Загора и региона. Мястото е важен културен център за любителите на историята и културата.",
                        Location = "бул. „Руски“ №42, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Архитектурен комплекс „Музей на религиите“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Архитектурен комплекс „Музей на религиите“ в Стара Загора предлага уникална експозиция, която разглежда религиозните вярвания и практики през различни исторически етапи. Музеят включва артефакти, свързани с различни религии и култури, като предоставя цялостен поглед върху развитието на религиозните традиции в региона. Комплексът е важен културен и исторически център, който показва как религията е формирала местната и национална идентичност.",
                        Location = "ул. „Славянска“ №1, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Градски бит XIX век“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Къща-музей „Градски бит XIX век“ в Стара Загора е посветена на начина на живот в градската среда през 19-ти век. Експозицията представя традиционни облекла, мебели и предмети от бита на старозагорци по време на Възраждането, като дава уникална представа за ежедневието, културата и социалната структура на този период. Музеят е ценен източник за изучаване на историческите и етнографските особености на региона.",
                        Location = "ул. „Славянска“ №2, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Музей „Литературна Стара Загора“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей „Литературна Стара Загора“ е посветен на богатото литературно наследство на Стара Загора. Експозицията представя творчеството на български писатели и поети, свързани с града, и проследява развитието на литературната култура в региона. Музеят съхранява книги, писмени документи и лични вещи на известни автори, които са допринесли за развитието на българската литература.",
                        Location = "ул. „Цар Симеон Велики“ №107, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Късноантична мозайка от частен римски дом (IV век)",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Късноантичната мозайка от частен римски дом, датираща от IV век, е важен археологически обект в Стара Загора. Мозайката е изключително добре запазена и представлява част от римски дом, който разкрива естетическите и архитектурни особености на времето. Тя е ценен пример за римската изкуствова традиция в България и дава поглед върху ежедневието на хората през този период.",
                        Location = "бул. „Ген. Столетов“ №117, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей „Гео Милев“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Къща-музей „Гео Милев“ е посветена на живота и творчеството на един от най-значимите български писатели и поети – Гео Милев. Музеят съхранява лични вещи, писма и ръкописи на автора, като същевременно предлага информация за неговото влияние върху българската литература и култура. Посетителите могат да се запознаят с творческите му търсения и социалната му ангажираност.",
                        Location = "ул. „Гео Милев“ №1, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Музей „Неолитни жилища“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей „Неолитни жилища“ представя уникални останки от неолитни жилища, включително най-добре запазеното двуетажно неолитно жилище в Европа, датиращо от началото на VI хилядолетие пр.н.е. Експозицията включва различни находки, като каменни инструменти и керамични съдове, които осветляват живота на древните хора и тяхната култура.",
                        Location = "ул. „Славянска“ №1, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Античен форумен комплекс на Августа Траяна",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Археологическият комплекс на Августа Траяна включва останки от античен форум, които отразяват историческото значение на Стара Загора през римската епоха. Комплексът е важен за изучаване на социалната и културната структура на римския град, като предоставя уникален поглед върху живота и архитектурата от този период.",
                        Location = "бул. „Руски“ №42, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    new MuseumModel
                    {
                        Name = "Музей „Хилендарски метох“",
                        RegionId = (int)RegionEnum.СтараЗагора,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей „Хилендарски метох“ е разположен в историческа сграда, свързана с историята на Хилендарския метох, и представя експозиции, отразяващи духовното наследство на региона. Музеят предоставя информация за важността на метоха в контекста на българската православна традиция и религиозната история на Стара Загора.",
                        Location = "ул. „Славянска“ №1, 6000 Стара Загора",
                        OpeningHours = "Вторник – Неделя: 10:00 – 18:00 ч.\nПочивен ден: Понеделник"
                    },

                    #endregion
                    #region Кърджали
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Кърджали",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Етнографски музей, който показва народните традиции, обичаи и култура на местното население.",
                        Location = "ул. „Цар Асен“ №14, гр. Кърджали",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота и Неделя: с предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей – Кирково",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей, съхраняващ археологически находки от региона на Кирково, които разкриват дълбоката история на района.",
                        Location = "гр. Кирково, ул. „Петър Мутафчиев“ №2, общ. Кирково",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на минералите – Кърджали",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музей, който представя уникална колекция от минерали и скални образувания от Източните Родопи.",
                        Location = "ул. „Републиканска“ №10, гр. Кърджали",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота: с предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Джебел",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Исторически музей, представящ археологически и етнографски експонати от района на Джебел.",
                        Location = "ул. „Георги Димитров“ №6, гр. Джебел",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота и Неделя: по заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на тютюна – Кърджали",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на историята на тютюнопроизводството в региона на Кърджали.",
                        Location = "ул. „Княз Александър Батенберг“ №6, гр. Кърджали",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота и Неделя: с предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на традициите и културата на родопите – Кърджали",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, който представя народната култура и традиции на родопите.",
                        Location = "гр. Кърджали, ул. „България“ №2",
                        OpeningHours = "Понеделник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота и Неделя: с предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Кърджали",
                        RegionId = (int)RegionEnum.Кърджали,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ богатото културно и историческо наследство на Източните Родопи.",
                        Location = "ул. „Републиканска“ №4, гр. Кърджали",
                        OpeningHours = "Лятно работно време (май – септември): Вторник – Петък: 09:00 – 12:00 и 13:00 – 17:00 ч.; Събота и Неделя: 09:00 – 17:00 ч.; Почивен ден: Понеделник. Зимно работно време (октомври – април): Вторник – Събота: 09:00 – 17:00 ч.; Почивни дни: Понеделник и Неделя."
                    },

                    #endregion
                    #region Кюстендил
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Кюстендил",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, представящ историята и културното наследство на региона Кюстендил.",
                        Location = "бул. „България“ №55, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 18:00 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Димитър Пешев“",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и делото на Димитър Пешев, видна фигура в българската история.",
                        Location = "ул. „Германея“ №1, гр. Кюстендил",
                        OpeningHours = "Април – Септември: Сряда – Неделя: 9:30 – 12:00 и 12:30 – 18:00 ч.; Октомври – Март: Сряда – Неделя: 9:30 – 12:00 и 12:30 – 17:00 ч.; Почивни дни: Понеделник и Вторник."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Димчо Дебелянов“",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и творчеството на поета Димчо Дебелянов.",
                        Location = "ул. „Георги Димитров“ №10, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:30 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:00 – 12:00 и 12:30 – 17:00 ч.; Почивен ден: Понеделник."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Тодор Каблешков“",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, отразяващ живота и дейността на революционера Тодор Каблешков.",
                        Location = "ул. „Цар Освободител“ №15, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:30 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:00 – 12:00 и 12:30 – 17:00 ч.; Почивен ден: Вторник."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Просветното дело",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на развитието на просветното дело в региона.",
                        Location = "ул. „Славянска“ №3, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:30 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:00 – 12:00 и 12:30 – 17:00 ч.; Почивен ден: Вторник."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Георги Бенковски“",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, отразяващ живота и борбата на революционера Георги Бенковски.",
                        Location = "ул. „Бенковски“ №8, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:30 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:00 – 12:00 и 12:30 – 17:00 ч.; Почивен ден: Сряда."
                    },
                    new MuseumModel
                    {
                        Name = "Галерия „Палавееви къщи“",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.ИзобразителноИзкуство,
                        Description = "Галерия, разположена в исторически къщи,展示ваща местни художници и занаятчии.",
                        Location = "ул. „Палавееви къщи“ №1, гр. Кюстендил",
                        OpeningHours = "Лятно работно време (април – септември): Понеделник – Неделя: 9:30 – 12:00 и 12:30 – 17:30 ч.; Зимно работно време (октомври – март): Понеделник – Неделя: 9:00 – 12:00 и 12:30 – 17:00 ч.; Почивен ден: Четвъртък."
                    },
                    new MuseumModel
                    {
                        Name = "Тепавица",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId =(int)MuseumTypeEnum.Археологически,
                        Description = "Археологически музей, представящ откритията от региона и важни исторически артефакти.",
                        Location = "с. Бобешино, община Кюстендил",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на старините в с. Слатино",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей, отразяващ археологическите находки от района и старините на селото.",
                        Location = "с. Слатино, община Кюстендил",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей \"Владимир Димитров-Майстора\"",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и творчеството на известния български художник Владимир Димитров-Майстора.",
                        Location = "с. Шишковци, община Кюстендил",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей \"Средновековна църква Св. Георги\"",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей, разположен в реставрирана средновековна църква,展示ващ исторически и археологически находки.",
                        Location = "гр. Кюстендил, ул. \"Цар Освободител\" №1",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Емфиеджиева къща",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Историческа къща,展示ваща традиционния бит и култура на региона.",
                        Location = "гр. Кюстендил, ул. \"Цар Освободител\" №5",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей \"Ильо Войвода\"",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и борбата на революционера Ильо Войвода.",
                        Location = "гр. Кюстендил, ул. \"Ильо Войвода\" №3",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Художествена галерия \"Владимир Димитров-Майстора\"",
                        RegionId = (int)RegionEnum.Кюстендил,
                        TypeStatusId = (int)MuseumTypeEnum.ИзобразителноИзкуство,
                        Description = "Галерия,展示ваща произведения на изкуството, включително творби на Владимир Димитров-Майстора.",
                        Location = "гр. Кюстендил, ул. \"Цар Освободител\" №7",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    #endregion
                    #region Ловеч
                    new MuseumModel
                    {
                        Name = "Исторически музей Ловеч",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, който представя историята на региона, включително археологически находки, етнографски и културни изложби.",
                        Location = "гр. Ловеч, ул. \"Васил Левски\" №1",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на воденичарството и занаятите",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей,展示ващ традиционните занаятчийски умения в Ловешкия край, включително воденичарството и други ръчно изработени занаяти.",
                        Location = "гр. Ловеч, ул. \"Търговска\" №5",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей на В. Левски",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на Апостола на свободата – Васил Левски,展示ващ неговото наследство и живот в Ловеч.",
                        Location = "гр. Ловеч, ул. \"Васил Левски\" №20",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на архитектурата на Ловеч",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.Архитектурен,
                        Description = "Музей, представящ архитектурните особености на Ловеч, със специален акцент върху стария град и архитектурните забележителности.",
                        Location = "гр. Ловеч, ул. \"Червената църква\" №8",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Ловешката крепост",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музей,展示ващ историята и археологическите находки от Ловешката крепост и региона около нея.",
                        Location = "гр. Ловеч, хълм \"Хисарлъка\"",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.; Събота и Неделя: 10:00 – 19:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей на Гео Милев",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и творчеството на българския писател и поет Гео Милев.",
                        Location = "гр. Ловеч, ул. \"Гео Милев\" №12",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей Тетевен",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, представящ историята на Тетевенския край, включително археологически находки и етнографски експонати.",
                        Location = "гр. Тетевен, ул. \"Хаджи Димитър\" №1",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къкринско ханче",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Исторически обект, свързан с живота на Васил Левски, където той е бил заловен. Днес функционира като музей.",
                        Location = "с. Къкрина, община Ловеч",
                        OpeningHours = "Понеделник – Неделя: 8:30 – 12:00 ч. и 13:30 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Народно читалище „Съгласие – 1869“",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Културен институт, предлагащ разнообразни изложби и културни събития. В него се намира и музейна сбирка с исторически и етнографски експонати.",
                        Location = "гр. Ловеч, пл. \"Тодор Кирков\" №3",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Природонаучен музей Черни Осъм",
                        RegionId = (int)RegionEnum.Ловеч,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музей,展示ващ разнообразие от природни експонати, включително флора и фауна от региона на Черни Осъм.",
                        Location = "гр. Троян, кв. Черни Осъм, ул. \"Христо Ботев\" №15",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    #endregion
                    #region Монтана
                    new MuseumModel
                    {
                        Name = "Исторически музей Монтана",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, представящ историята на Монтана и региона, включително археологически находки, етнографски и културни експонати.",
                        Location = "гр. Монтана, ул. \"Петко Славейков\" №2",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на воденичарството и занаятите",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей,展示ващ традиционните занаятчийски умения на региона, включително воденичарството и други занаятчийски умения.",
                        Location = "гр. Монтана, ул. \"Свобода\" №5",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей на Георги Бенковски",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и делото на Георги Бенковски, български национален герой и революционер.",
                        Location = "гр. Монтана, ул. \"Георги Бенковски\" №10",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на революционната борба",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на революционната борба в района и важни исторически събития от периода на Освобождението.",
                        Location = "гр. Монтана, ул. \"Тодор Александров\" №8",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Почивни дни: Събота и Неделя."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей Чипровци",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на историята и културата на Чипровци, включително експонати от исторически събития и местни занаяти.",
                        Location = "гр. Чипровци, ул. \"Цар Борис III\" №15",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей \"Иван Вазов\"",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.КултурноИсторически,
                        Description = "Музей, посветен на живота и творчеството на Иван Вазов, национален поет на България.",
                        Location = "гр. Берковица, ул. \"Иван Вазов\" №12",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей Берковица",
                        RegionId = (int)RegionEnum.Монтана,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей,展示ващ традиционния бит, култура и занаяти на региона Берковица.",
                        Location = "гр. Берковица, ул. \"Христо Ботев\" №8",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка."
                    },
                    #endregion
                    #region София област
                    new MuseumModel
                    {
                        Name = "Исторически музей – Ботевград",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Историческият музей в Ботевград представя археологически находки, етнографски експонати и документи, отразяващи историята на Ботевград и околността. Музеят е важен културен и образователен център, предоставящ информация за миналото на региона и развитието му през вековете.",
                        Location = "ул. „Ал. Стамболийски“ №1, 2130 Ботевград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Исторически музей – Етрополе",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Историческият музей в Етрополе разполага с експозиции, включващи археологически находки, етнографски материали и документи, свързани с историята на Етрополе. Музеят е важен за разбирането на развитието на града и региона през различни исторически епохи.",
                        Location = "ул. „Васил Левски“ №1, 2230 Етрополе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Исторически музей – Самоков",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Историческият музей в Самоков предлага експозиции, които отразяват историята на Самоков и региона, включително археологически находки и етнографски материали. Музеят е ценен източник за проучване на развитието на региона през различните исторически етапи.",
                        Location = "ул. „Искър“ №1, 2000 Самоков",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Музеен комплекс „Цари Мали Град“",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музеен комплекс „Цари Мали Град“ включва средновековна църква „Света Петка“, музейна част и антична крепост, разположена на хълма над тях. Периодите на изграждане на крепостта са два - на траките (VIII-VI в. пр. Хр.) и на римляните. Комплексът предлага уникално съчетание на археологически находки и историческо наследство.",
                        Location = "с. Белчин, община Самоков",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на рударството – Пирдоп",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей на рударството в Пирдоп показва историята на рударството в региона, със специално внимание към развитието на индустриалната дейност и важността на минералните ресурси в района. Музеят е ключов за разбирането на индустриалното наследство и развитието на района през вековете.",
                        Location = "с. Пирдоп, ул. „Гео Милев“ №1, 2080 Пирдоп",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на железниците – Елин Пелин",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Транспортен,
                        Description = "Музей на железниците в Елин Пелин показва историята на железниците и железопътния транспорт в България, като включва старинни локомотиви, вагони и други експонати. Музеят предоставя уникален поглед върху развитието на железопътния транспорт и неговото значение за България.",
                        Location = "гр. Елин Пелин, жп гара Елин Пелин, 2130",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 14:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на минералните извори – Самоков",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Геоложки,
                        Description = "Музеят на минералните извори в Самоков разказва за минералните извори и техните лечебни свойства, както и тяхната роля в развитието на региона като курортен център. Експозициите включват информация за геологията на района и значението на минералните води за здравето на хората.",
                        Location = "гр. Самоков, ул. „Искър“ №2, 2000",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Къща музей „Никола Пушкаров“ – Копривщица",
                        RegionId = (int)RegionEnum.СофияОбласт,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят е посветен на живота и творчеството на българския художник и педагог Никола Пушкаров. Експозицията включва негови произведения, лични вещи и документи, отразяващи неговия принос към българската култура.",
                        Location = "гр. Копривщица, ул. „Ген. Гурко“ №1",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    #endregion
                    #region Пазарджик
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят съхранява експонати от палеолита до средата на XX век, включително археологически находки и етнографски колекции.",
                        Location = "пл. 'Константин Величков' №15, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Батак",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя историята на Батак, включително събитията от Априлското въстание.",
                        Location = "ул. 'Цар Освободител' №1, Батак",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Брацигово",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на историята и културата на Брацигово и околността.",
                        Location = "ул. 'Христо Ботев' №2, Брацигово",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Велинград",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя археологически и етнографски експонати от района на Велинград.",
                        Location = "ул. 'Никола Вапцаров' №1, Велинград",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Панагюрище",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е известен със своите експозиции, свързани с Априлското въстание и историята на Панагюрище.",
                        Location = "ул. 'Хаджи Димитър' №9, Панагюрище",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически музей 'Проф. Мечислав Домарадски' – Септември",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музеят показва археологически находки от района на Септември и околностите.",
                        Location = "ул. 'Проф. Мечислав Домарадски' №1, Септември",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Исторически музей – Стрелча",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя историята на Стрелча и региона.",
                        Location = "ул. 'Цар Освободител' №1, Стрелча",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей 'Александър Стамболийски' – Славовица",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Личностен,
                        Description = "Музеят е посветен на живота и делото на българския политик и земеделски лидер Александър Стамболийски.",
                        Location = "ул. 'Александър Стамболийски' №1, Славовица",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Възраждането и народните традиции – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят представя традициите и обичаите на българския народ, както и културното и историческото наследство на региона.",
                        Location = "ул. 'Цар Освободител' №8, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на спорта – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Спортен,
                        Description = "Музеят предлага експозиции, свързани със спортната история и постижения на България и региона.",
                        Location = "бул. 'България' №72, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.; Събота и Неделя: 11:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей 'Михал Вълканов' – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Личностен,
                        Description = "Музеят е посветен на живота и делото на известния български общественик и патриот Михал Вълканов.",
                        Location = "ул. 'Петър Димков' №1, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на фармацевтиката – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музеят събира експонати, свързани с историята на фармацевтичната наука и индустрията в България.",
                        Location = "ул. 'Марица' №14, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на българската авиация – Пазарджик",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Авиационен,
                        Description = "Музеят разказва историята на българската авиация и нейния принос към развитието на въздухоплаването.",
                        Location = "ул. 'Калояново' №3, Пазарджик",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на древните занаяти – Пещера",
                        RegionId = (int)RegionEnum.Пазарджик,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят предлага експонати, свързани с традиционните български занаяти и тяхното значение в ежедневието на хората от Пещера.",
                        Location = "ул. 'Централна' №21, Пещера",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },

                    #endregion
                    #region Перник
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Перник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя археологически, етнографски и исторически експонати, отразяващи развитието на региона през вековете.",
                        Location = "ул. 'Физкултурна' №2, Перник",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Подземен минен музей – Перник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Уникален музей, разположен на 50 метра под земята, показващ развитието на минното дело в България с над 30 експозиции.",
                        Location = "ул. 'Физкултурна' №2, Перник",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Общински исторически музей – Брезник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя историята на Брезник и региона, включително археологически находки и етнографски колекции.",
                        Location = "ул. 'Борис Калев' №1, Брезник",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на минното дело – Перник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, посветен на историята на минното дело в Перник и региона, с експозиции, свързани с минната индустрия.",
                        Location = "ул. 'Миньорска' №5, Перник",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на възраждането – Перник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, който показва културното и историческото развитие на Перник по време на Възраждането.",
                        Location = "ул. 'Гоце Делчев' №2, Перник",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на транспорта – Перник",
                        RegionId = (int)RegionEnum.Перник,
                        TypeStatusId = (int)MuseumTypeEnum.Транспортен,
                        Description = "Музей, който показва историческото развитие на транспорта в региона, с акцент върху железниците и пътния транспорт.",
                        Location = "ул. 'Транспортна' №15, Перник",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    #endregion
                    #region Плевен
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят разполага с над 180 000 музейни експонати, отразяващи историята и културата на региона.",
                        Location = "ул. 'Стоян Заимов' №3, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей Панорама 'Плевенска епопея 1877'",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Посветен на освобождението на Плевен през 1877 г., музеят предлага панорамна експозиция на историческите събития.",
                        Location = "бул. 'Христо Ботев' №2, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей 'Велик княз Николай Николаевич' – Пордим",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, отразяващ дейността на Главната квартира на руската армия по време на Руско-турската война.",
                        Location = "ул. 'Цар Освободител' №1, Пордим 5801",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на виното – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музей, разположен в пещера, посветен на историята и традициите на винопроизводството в региона.",
                        Location = "Парк 'Кайлъка', 'Тотлебенов вал' №1, Плевен 5800",
                        OpeningHours = "Април – Октомври: 11:00 – 17:00 ч. (почивни дни: понеделник и вторник); Ноември – Март: По заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на изкуствата – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Изкуства,
                        Description = "Музей, който представя разнообразие от художествени произведения от различни епохи.",
                        Location = "ул. 'Димитър Константинов' №1, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, посветен на българските народни обичаи, занаяти и традиции.",
                        Location = "ул. 'Васил Левски' №10, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на народните музикални инструменти – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музей, който показва български народни музикални инструменти и тяхната роля в традиционната музика.",
                        Location = "Парк 'Кайлъка', Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 10:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на бойната слава – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, посветен на славните моменти от бойната история на Плевен по време на Руско-турската война.",
                        Location = "ул. 'Гео Милев' №4, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на текстила – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музей, който показва традициите на текстилната индустрия в региона и нейното значение за местната икономика.",
                        Location = "ул. 'Княз Александър Батенберг' №12, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на минералните води – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музей, който разказва историята на минералните извори в региона, както и техните здравни и лечебни свойства.",
                        Location = "бул. 'Христо Ботев' №1, Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей 'Иван Вазов' – Чирен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей, посветен на живота и творчеството на великия български писател Иван Вазов, разположен в родния му край.",
                        Location = "с. Чирен, община Плевен, 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на армията – Плевен",
                        RegionId = (int)RegionEnum.Плевен,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, посветен на военната история на България, включващ експонати от различни епохи.",
                        Location = "Парк 'Кайлъка', Плевен 5800",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: Почивен ден"
                    },
                    #endregion
                    #region София град
                    new MuseumModel
                    {
                        Name = "Национален исторически музей (НІМ)",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят съхранява над 700 000 експоната, които отразяват историята на България от праисторията до съвременността.",
                        Location = "бул. „Цар Освободител“ №16, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Национален археологически музей",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Това е един от най-старите и най-богати археологически музеи в България. В музея са изложени находки от различни исторически епохи, включително тракийски и римски експонати.",
                        Location = "ул. „Света София“ №2, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Национален природонаучен музей",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музеят предлага експозиции, свързани с природата, минерали, растения, животни и геология. Той също така има редица интерактивни изложби.",
                        Location = "бул. „Цар Освободител“ №1, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на изкуствата „Земята и хората“",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Геоложки,
                        Description = "Музеят има уникална колекция от минерали и скъпоценни камъни, които се намират в България и по света.",
                        Location = "бул. „Цар Освободител“ №16, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на съвременното изкуство (София)",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Музеят предлага широка гама от експозиции на съвременно изкуство, включително инсталации, картини, скулптури и видеозаписи.",
                        Location = "бул. „Витоша“ №6, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Софийска градска художествена галерия",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Градската галерия има постоянни и временни изложби на български и чуждестранни художници. Тя е важен културен център за изкуствата в София.",
                        Location = "пл. „Журналист“ №1, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на социалистическото изкуство",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят събира произведения на изкуствата от периода на социализма в България, включително скулптури, картини и плакати.",
                        Location = "ул. „Луи Пастьор“ №7, 1113 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Иван Вазов“",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Къщата на Иван Вазов е превърната в музей, посветен на живота и творчеството на „покровителя на българската литература“. Тук може да се видят негови лични вещи, писма и ръкописи.",
                        Location = "ул. „Иван Вазов“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на авиацията",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Транспортен,
                        Description = "Музеят е посветен на историята на българската авиация и съдържа различни авиационни експонати, включително старинни самолети и двигатели.",
                        Location = "бул. „Цариградско шосе“ №78, 1113 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на спорта",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Спортен,
                        Description = "Музеят разказва за развитието на спорта в България, като включва трофеи, екипи, снимки и други експонати, свързани с български спортисти.",
                        Location = "ул. „Васил Левски“ №19, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на медицината",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Медицински,
                        Description = "Музеят събира и представя историята на медицината, от древни времена до съвременността, и се фокусира върху развитието на медицинските технологии и техники.",
                        Location = "ул. „Пиротска“ №9, 1200 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: По предварителна уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на шоколада",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музеят представя историята на шоколада, производствени процеси и разнообразие от шоколадови изкушения и сладки изделия.",
                        Location = "ул. „Бенковски“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на комунизма",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя исторически документи, фотографии и експонати, които разказват за периода на социализма и комунистическото управление в България.",
                        Location = "бул. „Цариградско шосе“ №179, 1784 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на българската армия",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Военен,
                        Description = "Музеят събира исторически и военни експонати, свързани с историята на българската армия от древността до съвременността, включително военни униформи, оръжия и техники.",
                        Location = "бул. „Цар Освободител“ №16, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: 10:00 – 18:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на килимите",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят е посветен на българските традиции в тъкачеството и включва уникални експонати от различни региони на страната. Събира тъкани, килими и текстилни изделия.",
                        Location = "ул. „Калоян“ №6, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на хумора и сатирата",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Изкуства,
                        Description = "Музеят се намира в квартал „Сатиричен театър“ и представя интересни и хумористични изложби, вдъхновени от българската сатира, карикатури и комедиен театър.",
                        Location = "ул. „Хумор и сатира“ №5, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на възраждането",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят разказва за събитията от периода на Българското възраждане, с акцент на социалните и политически промени през 18-19 век. В него могат да се видят картини, документи и лични вещи на личности от това време.",
                        Location = "ул. „Гео Милев“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на българските авиатори",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Авиационен,
                        Description = "Музеят показва историята на българските летци и авиацията в България, включително важни исторически събития и развитието на авиационната индустрия.",
                        Location = "ул. „Дондуков“ №1, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на народните художествени занаяти и приложните изкуства",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят събира и представя творби на народните занаяти и приложни изкуства от различни региони на България.",
                        Location = "ул. „Ген. Гурко“ №8, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на историческата библиотека на България",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Този музей показва историята на българската библиотека и архиви, с акцент на старинни книги и ръкописи, съхранявани през вековете.",
                        Location = "ул. „Петко Каравелов“ №12, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: По уговорка"
                    },

                    new MuseumModel
                    {
                        Name = "Музей на книгата",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музеят е посветен на историята на книгопечатането и книгоиздаването в България. Той включва колекции от стари ръкописи, книги, печатни издания и машините, използвани през вековете.",
                        Location = "ул. „Ген. Йосиф В. Раковски“ №7, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на фотографията",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Фотографски,
                        Description = "Музеят представя историята на фотографията, с акцент върху развитието на техниката, фотографиите и стилистиката през различните епохи. Има и голяма колекция от стари фотоапарати.",
                        Location = "ул. „Славянска“ №5, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на изкуствата „Галерия 4“",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Галерията представя съвременни художници и техните произведения. Изложбите обхващат различни форми на изкуство – живопис, скулптура, инсталации и др.",
                        Location = "ул. „Граф Игнатиев“ №19, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на народния бит и култура в България",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят представя традиционния български бит и култура, с експонати, свързани с народни обичаи, костюми, музикални инструменти и ръчно изработени предмети.",
                        Location = "бул. „Цар Освободител“ №99, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на модерното изкуство",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.СъвременноИзкуство,
                        Description = "Този музей се фокусира върху съвременните течения в изкуствата, като представя нови подходи в живописта, скулптурата и инсталациите.",
                        Location = "бул. „Черни връх“ №9, 1404 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на кибернетиката",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музеят демонстрира развитието на кибернетиката и информационните технологии в България, с експонати за компютърните науки и иновации.",
                        Location = "ул. „Шишман“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на водката",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музеят представя историята на водката и други спиртни напитки, като разказва как те се произвеждат и влияят на социалните обичаи.",
                        Location = "ул. „Бенковски“ №7, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на историята на фотографията и киното",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Изкуства,
                        Description = "Този музей е посветен на развитието на фотографията и киното. В него се показват редки колекции от стари филмови апарати и фотографски устройства.",
                        Location = "ул. „Георги Бенковски“ №8, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Българския театър",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Театрален,
                        Description = "Музеят събира експонати, свързани с историята на българския театър, с акцент върху най-известните театрални постановки и актьори в България.",
                        Location = "бул. „Витоша“ №13, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на съвременното изкуство и визуални изкуства",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.СъвременноИзкуство,
                        Description = "Музеят предлага разнообразие от експозиции, свързани с новите течения в изкуството. Тук се представят както български, така и международни художници.",
                        Location = "бул. „Цариградско шосе“ №147, 1124 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на медицината",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музеят представя историята на медицината и медицинските технологии в България и по света. В експозицията са включени инструменти и материали, използвани от древността до съвременността.",
                        Location = "ул. „Раковски“ №47, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на образованието",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Образователен,
                        Description = "Музеят показва развитието на образованието в България през вековете. Експонатите включват стари учебници, писмени материали, педагогически инструменти и документи, свързани с образователния процес.",
                        Location = "ул. „Св. Св. Кирил и Методий“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на фолклорната музика",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Музикален,
                        Description = "Музеят е посветен на българския фолклор и музикални традиции. В него могат да се видят народни инструменти и да се чуят записи на фолклорна музика от различни региони на България.",
                        Location = "ул. „Дондуков“ №1, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на авангардното изкуство",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.СъвременноИзкуство,
                        Description = "Този музей е посветен на авангардното изкуство, с колекции от произведения на художници, които са революционни в подхода и изразните средства в изкуствата.",
                        Location = "ул. „Софийски университет“ №10, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на пейзажната живопис",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Музеят е посветен на пейзажната живопис и включва творби на български и международни художници, които са изобразявали природата и градските пейзажи.",
                        Location = "ул. „Пиротска“ №11, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на театралното изкуство",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Театрален,
                        Description = "Музеят е посветен на театралното изкуство и историята на театъра в България, с акцент върху театрални костюми, декори, сценични предмети и значими театрални личности.",
                        Location = "ул. „Цар Асен I“ №6, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на музикалната техника",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музеят демонстрира еволюцията на музикалната техника – от старинни музикални инструменти до съвременни технологични иновации в производството на музикални уреди и записи.",
                        Location = "ул. „Цар Борис III“ №4, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на изкуствата на културите",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Музеят обединява различни култури и представя тяхното изкуство – от древни цивилизации до съвременността, с фокус върху синтеза на изкуствата от различни региони и култури.",
                        Location = "ул. „Иван Вазов“ №12, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Музей на историята на София",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят разказва историята на София от праисторията до съвременността, с множество експонати, които показват развитието на града, неговите обичаи и култура.",
                        Location = "пл. „Света Неделя“ №1, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на българския етнографски фолклор",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Този музей се фокусира върху българските народни обичаи и фолклор, включително музика, танци, носии, и предмети от ежедневието на българския народ.",
                        Location = "ул. „Цариградско шосе“ №217, 1113 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на ретро автомобилите",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Транспортен,
                        Description = "Музеят предлага уникална колекция от ретро автомобили, мотоциклети и други транспортни средства, които илюстрират развитието на моторната индустрия през 20-ти век.",
                        Location = "ул. „Св. Георги“ №6, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на българския ювелир",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на българската златарска традиция, с експонати от различни епохи – от древността до съвременността. Включва красиви бижута и предмети, изработени с изключителни умения.",
                        Location = "ул. „Лъчезар Станчев“ №12, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на минералите",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музеят предлага уникални колекции от минерали, скъпоценни камъни и минералогични образци, които илюстрират богатото минерално разнообразие на България и света.",
                        Location = "ул. „Солунска“ №27, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на занаятите и традиционните изкуства",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Този музей е посветен на различни народни занаяти и традиционни български изкуства, като дърворезба, тъкачеството, керамика и металургия. Той показва уменията на българските занаятчии през вековете.",
                        Location = "ул. „Александър Бенковски“ №5, 1000 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на пчеларството",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Тематичен,
                        Description = "Музеят разказва историята на пчеларството в България, включително различни аспекти на производството на мед, восък и други продукти от пчели. Включва и демонстрации на пчеларски уреди.",
                        Location = "ул. „Димитър Петков“ №4, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на астрофизиката",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Научен,
                        Description = "Музеят е посветен на астрономията и астрофизиката, като предлага интересни експонати, свързани с космоса, планетите, звездите и развитието на астрономическите изследвания.",
                        Location = "бул. „Никола Габровски“ №13, 1113 София",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.\nСъбота и Неделя: по уговорка"
                    },
                    new MuseumModel
                    {
                        Name = "Музей на космонавтиката",
                        RegionId = (int)RegionEnum.СофияГрад,
                        TypeStatusId = (int)MuseumTypeEnum.Космически,
                        Description = "Музеят предлага експонати за историята на космическите изследвания, с особен акцент на българския принос в космонавтиката, както и модели на сателити и ракети.",
                        Location = "ул. „Софийски космонавт“ №15, 1000 София",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    #endregion
                    #region Смолян
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей „Стою Шишков“ – Смолян",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят разполага с богата колекция от археологически и етнографски експонати. Той е посветен на историята на района и е кръстен на Стою Шишков – известен български историк и писател. Музеят е разделен на различни сбирки, представящи културата и живота на местните хора през вековете.",
                        Location = "ул. „Никола Вранчев“ №30, 4700 Смолян",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на естествената история в Смолян",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музеят е посветен на природата на Родопите и обогатен с експонати, които показват флората и фауната на региона. Включва различни видове птици, животни и растения, характерни за този планински район.",
                        Location = "ул. „Цар Освободител“ №1, 4700 Смолян",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.\nСъбота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Рождество Христово",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Религиозен,
                        Description = "Музеят се намира в църквата „Рождество Христово“ в Смолян и е посветен на християнските традиции в региона. Той включва икони, старинни реликви и експонати, свързани с православната вяра и духовния живот на Родопите.",
                        Location = "ул. „Рождество Христово“ №3, 4700 Смолян",
                        OpeningHours = "Понеделник – Неделя: 9:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на Стоте години - Смолян",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е открит в чест на стогодишнината от създаването на Смолян и е насочен към събитията, които се случват в града през този период. Включва снимки, документи и различни артефакти, които разказват историята на региона през 20-ти век.",
                        Location = "ул. „Мала“ №15, 4700 Смолян",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Планетариум Смолян",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Астрономически,
                        Description = "Планетариумът предлага интерактивни изложби, свързани с астрономията и космоса, както и прожекции на звездното небе и образователни програми за всички възрасти.",
                        Location = "бул. „България“ №56, 4700 Смолян",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.; Събота и Неделя: 10:00 – 14:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей на открито „Широка лъка“",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят на открито представя традиционната родопска архитектура и начин на живот чрез автентични къщи, облекла и занаятчийски работилници.",
                        Location = "с. Широка лъка, община Смолян",
                        OpeningHours = "Понеделник – Неделя: 9:00 – 18:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Къща-музей на капитан Петко Войвода – Широка лъка",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на живота и делото на капитан Петко Войвода, известен български хайдутин и революционер.",
                        Location = "с. Широка лъка, община Смолян",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с местните власти за актуална информация."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на магията – Момчиловци",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят представя различни аспекти на магията и мистицизма в родопската култура, включително обреди, ритуали и вярвания.",
                        Location = "с. Момчиловци, община Смолян",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с местните власти за актуална информация."
                    },

                    new MuseumModel
                    {
                        Name = "Музейна сбирка „Смилянски фасул и родопски терлици” – Смилян",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Сбирката, разположена в читалище „Асен Златаров-1927“, е открита през 2005 г. и представя традиционни родопски ястия и облекло, като акцентира върху уникалния смилянски фасул и характерните за региона терлици.",
                        Location = "с. Смилян, община Смолян",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с местните власти за актуална информация."
                    },
                    new MuseumModel
                    {
                        Name = "Музейна сбирка – Давидково",
                        RegionId = (int)RegionEnum.Смолян,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Етнографската сбирка в село Давидково е разположена в местното Народно читалище 'Зора'. Тя съхранява стотици експонати от 19 и началото на 20 век, отразяващи традиционния бит, облекло и занаятите на местното население.",
                        Location = "с. Давидково, община Баните",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с местните власти за актуална информация."
                    },
                    #endregion
                    #region Русе
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Русе",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя историята на Русе и региона чрез разнообразни експозиции, включително археологически находки и етнографски материали.",
                        Location = "ул. „Борисова“ №39, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Екомузей с аквариум",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Единствен по рода си в България, този музей комбинира природонаучна експозиция с аквариум, отразявайки богатството на флората и фауната на река Дунав.",
                        Location = "пл. „Александър Батенберг“ №3, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 18:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Национален музей на транспорта и съобщенията",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Транспортен,
                        Description = "Музеят проследява развитието на транспортните и комуникационни технологии в България, с акцент върху железопътния транспорт.",
                        Location = "бул. „България“ №2, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:30 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Баба Тонка“",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Посветена на живота и делото на Баба Тонка, видна фигура от Българското възраждане, къщата отразява историческите събития от този период.",
                        Location = "ул. „Баба Тонка“ №2, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Нумизматичен музей Русе",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Нумизматичен,
                        Description = "Първият частен музей в България, той притежава обширна колекция от монети и артефакти. В момента сградата е в процес на реновация и предстои откриване.",
                        Location = "бул. „Борисова“ №33, 7000 Русе",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с музея за актуална информация."
                    },

                    new MuseumModel
                    {
                        Name = "Музей „Градски бит на Русе”",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят представя традиционния градски бит на Русе от края на XIX и началото на XX век, с акцент върху облеклата, мебелите и предметите от всекидневието.",
                        Location = "ул. „Александровска“ №69, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Тома Кърджиев”",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Посветена на живота и делото на Тома Кърджиев, виден общественик и дарител, къщата отразява историческите събития и социалния живот в Русе през неговото време.",
                        Location = "ул. „Борисова“ №39, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Пантеон на възрожденците",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.ИсторическиМемориал,
                        Description = "Пантеонът е посветен на видни личности от Българското възраждане, чиито усилия са били ключови за развитието на града и нацията.",
                        Location = "ул. „Борисова“ №39, 7000 Русе",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Римска крепост Сексагинта Приста",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Сексагинта Приста е антична римска крепост, разположена на територията на съвременен Русе. Тя е била важен военен и търговски пункт по време на Римската империя.",
                        Location = "гр. Русе",
                        OpeningHours = "Тъй като обектът е археологическа зона на открито, той е достъпен за посещения през цялата година. Препоръчително е да се свържете с местните власти за подробности и насоки."
                    },
                    new MuseumModel
                    {
                        Name = "Ивановски скални църкви",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Комплекс от средновековни църкви, изсечени в скалите, включен в списъка на световното наследство на ЮНЕСКО. Тези църкви са известни със своите уникални фрески и архитектура.",
                        Location = "с. Иваново, община Русе",
                        OpeningHours = "Всеки ден: 8:00 – 18:00 ч. (часовете може да варират в зависимост от сезона)"
                    },
                    new MuseumModel
                    {
                        Name = "Средновековен град Червен",
                        RegionId = (int)RegionEnum.Русе,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Средновековен град, известен със своите добре запазени крепостни стени и църкви. Той е бил важен търговски и военен център през Средновековието.",
                        Location = "с. Червен, община Русе",
                        OpeningHours = "Всеки ден: 8:00 – 19:00 ч. (работното време може да се променя през зимните месеци)"
                    },
                    #endregion
                    #region Разград
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Разград",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят включва археологически, етнографски и исторически експозиции, които разказват за развитието на региона и културното наследство на Разград.",
                        Location = "бул. „Априлско въстание“ № 70, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Археологически резерват „Абритус“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "„Абритус“ е античен римски град, известен със своите добре запазени руини. В района могат да се видят останки от крепостни стени, бани, улици и храмове от времето на Римската империя.",
                        Location = "гр. Разград",
                        OpeningHours = "Всеки ден: 8:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Разград",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят показва традиционния бит на населението в района на Разград. Експозициите включват народни носии, домакински съдове и инструменти, свързани с ежедневния живот на българите през различни исторически периоди.",
                        Location = "ул. „Цар Освободител“ № 8, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Анание Явашов“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Посветена на живота и делото на Анание Явашов, историк и общественик. Музеят разказва за неговата работа в областта на българската история и просвета.",
                        Location = "ул. „Иван Вазов“ № 1, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Димитър Ненов“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на живота и делото на Димитър Ненов, известен педагог и общественик в региона.",
                        Location = "ул. „Васил Левски“ № 5, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Художествена галерия „Проф. Илия Петров“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.ХудожественаГалерия,
                        Description = "Галерията е открита през 1972 г. и притежава фонд от над 3500 произведения на изобразителното изкуство, датиращи от IX до XX век.",
                        Location = "ул. „Венелин“ №20, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Станка и Никола Икономови“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на живота и делото на Станка и Никола Икономови, видни общественици и дарители в региона.",
                        Location = "ул. „Цар Освободител“ №12, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Къща музей „Ибрахим паша джамия“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Джамията е построена през 1516 г. и е третата по големина на Балканския полуостров. Известна е със своето архитектурно великолепие и историческо значение.",
                        Location = "ул. „Ибрахим паша“ №1, 7000 Разград",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },

                    new MuseumModel
                    {
                        Name = "Исторически музей – Исперих",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя историята на града и региона чрез археологически находки, етнографски експонати и исторически документи.",
                        Location = "ул. „Цар Освободител“ № 1, 7740 Исперих",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },
                    new MuseumModel
                    {
                        Name = "Етнографска къща – Исперих",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Къщата демонстрира традиционния бит и култура на местното население с автентични предмети и обстановка.",
                        Location = "ул. „Васил Левски“ № 5, 7740 Исперих",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },

                    new MuseumModel
                    {
                        Name = "Историко-археологически резерват „Сборяново“",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.АрхеологическиРезерват,
                        Description = "Резерватът обхваща територията на Лудогорското плато и включва множество археологически и исторически обекти, свидетелстващи за богатото минало на региона. Мястото е известно със своето културно значение и е дом на известната Свещарска гробница.",
                        Location = "с. Свещари, община Исперих",
                        OpeningHours = "Всеки ден: 8:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Гаговска гробница",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Тракийска гробница от IV-III век пр.н.е. Гробницата се намира в природен парк и е част от археологическото наследство на района, предоставяща информация за тракийската култура и погребалните практики.",
                        Location = "край с. Гагово, община Попово",
                        OpeningHours = "Всеки ден: 8:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Демир баба теке",
                        RegionId = (int)RegionEnum.Разград,
                        TypeStatusId = (int)MuseumTypeEnum.Религиозен,
                        Description = "Демир баба теке е религиозен комплекс и обект на поклонение, с известен културен и исторически контекст, свързан с османската епоха.",
                        Location = "близо до с. Демир баба, община Исперих",
                        OpeningHours = "Всеки ден: 8:00 – 18:00 ч."
                    },
                    #endregion
                    #region Силистра
                    new MuseumModel
                    {
                        Name = "Регионален исторически музей – Силистра",
                        RegionId = (int)RegionEnum.Силистра,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят разполага с археологическа и етнографска експозиция, отразяващи историята на региона от праисторически до съвременни времена.",
                        Location = "ул. „Г. Раковски“ №24, 7500 Силистра",
                        OpeningHours = "Лятно (май – октомври): 9:30 – 12:00 и 12:30 – 17:00 ч.; Зимно (ноември – април): 9:30 – 12:00 и 12:30 – 17:00 ч. Почивни дни: неделя и понеделник (лято); събота и неделя (зима)."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Силистра",
                        RegionId = (int)RegionEnum.Силистра,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Част от Регионален исторически музей, този музей представя бита и културата на населението от Силистренския регион от средата на XIX до средата на XX век.",
                        Location = "ул. „Г. Раковски“ №24, 7500 Силистра",
                        OpeningHours = "От понеделник до събота: 9:00 – 12:00 и 13:00 – 18:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Природонаучен музей и природен резерват „Сребърна“",
                        RegionId = (int)RegionEnum.Силистра,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Природонаучният музей в Сребърна е разположен в непосредствена близост до едноименния природен резерват, включен в списъка на световното наследство на ЮНЕСКО. Музеят предлага информация за флората и фауната на района, като акцентира върху уникалната орнитологична значимост на езерото Сребърна.",
                        Location = "с. Сребърна, община Силистра",
                        OpeningHours = "Информацията за работното време не е налична; препоръчително е да се свържете с местните власти за актуална информация."
                    },

                    new MuseumModel
                    {
                        Name = "Етнографски музей „Дунавски риболов и лодкостроене“",
                        RegionId = (int)RegionEnum.Силистра,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят е посветен на традициите на риболов и лодкостроене по река Дунав. Експозицията включва уникални уреди и пособия за риболов от различни исторически периоди.",
                        Location = "ул. „Христо Ботев“ №1, 7690 Тутракан",
                        OpeningHours = "Понеделник – Петък: 8:30 – 17:00 ч.; Събота и Неделя: 9:00 – 13:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на комунизма",
                        RegionId = (int)RegionEnum.Силистра,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят представя експонати от периода на социализма в България. Експонатите са дарени от местни жители и включват предмети, използвани през годините на комунизма.",
                        Location = "с. Гарван, община Силистра",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна уговорка"
                    },
                    #endregion
                    #region Пловдив
                    new MuseumModel
                    {
                        Name = "Регионален археологически музей – Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Музеят е един от най-старите в България и разполага с колекции от археологически находки, които отразяват историята на Пловдив и региона през различни исторически епохи.",
                        Location = "ул. „Цар Иван Асен II“ №1, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Регионален етнографски музей – Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Този музей е разположен в реставрирана възрожденска къща и представя традиционния бит и култура на Пловдивския регион.",
                        Location = "ул. „Д-р Ст. Чомаков“ №2, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Природонаучен музей – Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Природонаучен,
                        Description = "Музеят е вторият по големина природонаучен музей в България и разполага с впечатляваща колекция от минерали, фауна и флора.",
                        Location = "бул. „Цар Борис III Обединител“ №1, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Епископската базилика на Филипопол",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Една от най-големите раннохристиянски църкви в България, разположена на територията на старата римска колония Филипопол.",
                        Location = "ул. „Цар Борис III Обединител“ №1, Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на авиацията – Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Авиационен,
                        Description = "Музей, който се намира на територията на летището в Пловдив и представя българската авиационна история с разнообразие от авиационни експонати и самолети.",
                        Location = "Летище Пловдив, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на историята на Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, който представя историята на Пловдив от античността до съвременността. Експозициите му обхващат различни етапи на развитието на града.",
                        Location = "ул. „Съборна“ №1, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Римски стадион",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Археологически,
                        Description = "Римският стадион в Пловдив е сред най-значимите археологически открития в града и е пример за голямо римско съоръжение от II век.",
                        Location = "ул. „Съборна“, 4000 Пловдив",
                        OpeningHours = "Всеки ден: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на съвременното изкуство",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Художествен,
                        Description = "Музей, фокусиран върху съвременното изкуство и създаден с цел да представи българските и международни съвременни художници.",
                        Location = "ул. „Княз Александър I“ №15, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Галерия „Дяков“",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.ИзобразителноИзкуство,
                        Description = "Галерия, в която се организират изложби на български и международни художници. Акцентът е върху съвременното изкуство.",
                        Location = "ул. „Княз Александър I“ №15, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: по предварителна заявка"
                    },

                    new MuseumModel
                    {
                        Name = "Галерия „Лабиринт“ – Пловдив",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.ИзобразителноИзкуство,
                        Description = "Малка, домашна галерия, разположена в стара къща на Главната улица, предлагаща вълнуваща среща с интересни автори и качествено изкуство.",
                        Location = "ул. „Ангел Букурещлиев“ №1, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 10:00 – 18:00 ч.; Събота и Неделя: по предварителна заявка"
                    },

                    new MuseumModel
                    {
                        Name = "Национален музей „Васил Левски“ – Карлово",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на живота и делото на Васил Левски и събира документи, лични вещи и експонати, свързани с неговата революционна дейност.",
                        Location = "ул. „Генерал Карцов“ №57, 4300 Карлово",
                        OpeningHours = "Понеделник – Петък: 8:30 – 13:00 ч. и 14:00 – 17:30 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на авиацията – Крумово",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Авиационен,
                        Description = "Музей, разположен в близост до летище Крумово, който съхранява и показва българската авиационна история с експонати на старинни самолети и авиационна техника.",
                        Location = "Летище Крумово, 4000 Пловдив",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч.; Събота и Неделя: 10:00 – 18:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Етнографски музей – Брезово",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музеят представя традиционния живот и култура на хората в региона, като обхваща народни обичаи, облекло, занаяти и домакински уреди.",
                        Location = "с. Брезово, Пловдивска област",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на възраждането – Сопот",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музеят е посветен на възрожденската история на Сопот и е свързан с революционната и просветителската дейност на региона.",
                        Location = "ул. „Генерал Карцов“ №12, 4330 Сопот",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Къща-музей „Иван Вазов“ – Сопот",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Литературен,
                        Description = "Музей в родния дом на Иван Вазов, българския национален поет и писател, който представя неговия живот и творчество.",
                        Location = "ул. „Иван Вазов“ №12, 4330 Сопот",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    },

                    new MuseumModel
                    {
                        Name = "Исторически музей – Първомай",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Исторически,
                        Description = "Музей, който разказва историята на Първомай и околията от древността до съвременността.",
                        Location = "ул. „Георги Кирков“ №1, 4230 Първомай",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    },
                    new MuseumModel
                    {
                        Name = "Музей на фолклора – Куклен",
                        RegionId = (int)RegionEnum.Пловдив,
                        TypeStatusId = (int)MuseumTypeEnum.Етнографски,
                        Description = "Музей, посветен на народните традиции, обичаи и занаяти в района на Пловдив и близките села.",
                        Location = "с. Куклен, Пловдивска област",
                        OpeningHours = "Понеделник – Петък: 9:00 – 17:00 ч."
                    }
                    #endregion
                };
                await database.InsertAllAsync(museums);
            }
        }
    }
}
