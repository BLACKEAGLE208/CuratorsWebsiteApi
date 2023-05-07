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
                        firstName = "iPhone X",
                        secondName = "Apple",
                        facultyId = 1
                    },
                    new Curator
                    {
                        firstName = "Samsung Galaxy Edge",
                        secondName = "Samsung",
                        facultyId = 2
                    },
                    new Curator
                    {
                        firstName = "Pixel 3",
                        secondName = "Google",
                        facultyId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
