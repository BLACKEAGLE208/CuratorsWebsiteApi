using System.Linq;
using System.Numerics;
using CuratorsWebApi.Models;

namespace CuratorsWebApi
{
    public static class SampleData
    {
        public static void Initialize(CuratorsContext context)
        {
            if (!context.Curators.Any())
            {
                context.Curators.AddRange(
                    new Curator
                    {
                        FirstName = "iPhone X",
                        SecondName = "Apple",
                        faculty_id = 1
                    },
                    new Curator
                    {
                        FirstName = "Samsung Galaxy Edge",
                        SecondName = "Samsung",
                        faculty_id = 2
                    },
                    new Curator
                    {
                        FirstName = "Pixel 3",
                        SecondName = "Google",
                        faculty_id = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
