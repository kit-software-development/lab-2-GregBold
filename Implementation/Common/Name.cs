namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
        /// <summary>
        ///     Полная форма имени.
        /// </summary>
        public string FullName { get; }
        /// <summary>
        ///     Короткая форма имени.
        /// </summary>
        public string ShortName { get; }

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }

        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }

        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;
            int FirstSpace = FullName.IndexOf(' ');
            int SecondSpace = FullName.Substring(FirstSpace + 1).IndexOf(' ');
            FirstName = FullName.Substring(0, FirstSpace);
            Surname = FullName.Substring(FirstSpace, SecondSpace);
            Patronymic = FullName.Substring(SecondSpace + 1);
        }

        public Name(string name, string surname, string patronymic)
        {
            FirstName = name;
            Surname = surname;
            Patronymic = patronymic;
            FullName = name + ' ' + surname + ' ' + patronymic;
            ShortName = name + ' ' + surname[0] + ' ' + patronymic[0];
        }



    }
}
