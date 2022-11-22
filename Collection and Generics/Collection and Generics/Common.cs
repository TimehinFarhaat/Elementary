namespace Collection_and_Generics
{
    class Common<T>where T:Living
    {
        public string GetNameToUpper(T  obj)
        {
            return obj.GetName().ToUpper();
        }
    }
}
