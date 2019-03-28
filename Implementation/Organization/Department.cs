namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */

        public Department(IDepartment depart)
        {
            Name = depart.Name;
        }

        public string Name{get;}

        public Department(string name)
        {
            Name = name;
        }

    }
}
