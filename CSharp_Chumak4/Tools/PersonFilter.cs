using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Chumak4.Tools
{
    public static class PersonFilter
    {
        public static readonly string[] FilterParams =
                 Array.ConvertAll(typeof(User).GetProperties(), (property) => property.Name);

        public static List<User> FilterByParam(this List<User> users, string property, string query)
        {
            if (Array.IndexOf(FilterParams, property) < 0) return new List<User>();

            query = query.ToLower();
            return (users.Where(p =>
                // ReSharper disable once PossibleNullReferenceException
                property != null && (p.GetType().GetProperty(property)?.GetValue(p, null)).ToString().ToLower()
                .Contains(query))).ToList();
        }
    }
}
