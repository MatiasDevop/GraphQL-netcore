using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        //[UseProjection] remove thi because now we have resolvers
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context){
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        //[UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Command> GetCommand([ScopedService] AppDbContext context){
            return context.Commands;
        }
    }
}