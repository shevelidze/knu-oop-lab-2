using System;
using System.Text;

namespace KnuOopLab2
{
    class DormitorySearch
    {
        public DormitorySearch(IDormitorySearchStrategy searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public void startShellLoop()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string[] attributeNames = { "name", "faculty", "year", "building", "address"};

            while (true)
            {

                var attributeName = Prompt.ReadString("За яким атрибутом хочете здійснити пошук?", attributeNames, "Невірне ім'я атрибуту.");
                Console.Write("Пошук: ");
                var searchPattern = Console.ReadLine();

                foreach (var inmate in _searchStrategy.searchByAttribute(attributeName, searchPattern))
                {
                    Console.WriteLine(String.Format("ПІБ: {0} Факультет: {1} Курс: {2} Корпус: {3} Адреса: {4}", inmate.Name,
                        inmate.FacultyName, inmate.StudyingYear, inmate.Building, inmate.Address));
                }
            }
        }

        private IDormitorySearchStrategy _searchStrategy;
    }
}
