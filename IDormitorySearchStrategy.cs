namespace KnuOopLab2
{
    interface IDormitorySearchStrategy
    {
        public Inmate[] searchByAttribute(string attributeName, string pattern);
    }
}
