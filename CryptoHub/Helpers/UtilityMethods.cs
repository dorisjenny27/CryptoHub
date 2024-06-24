namespace CryptoHub.Helpers
{
    public class UtilityMethods
    {
        public static IEnumerable<T> Paginate<T>(List<T> source, int page, int pageSize)
        {
            // Ensure page number is at least 1
            if (page < 1) page = 1;
            // Ensure page size is at least 10
            if (pageSize < 10) pageSize = 10;

            // Return the paginated part of the list
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }

}
