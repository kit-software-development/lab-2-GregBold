using Practice.HR.Events;
using Practice.Common;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {

        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */

        private Name name;

        public IName Name
        {
            get { return name; }
            set
            {
                ValueChangeEventArgs<IName> args = new ValueChangeEventArgs<IName>(name);
                NameChange?.Invoke(this, args);
                name = new Name(value);
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;

    }
}
