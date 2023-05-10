using ApiGraphQL.Models;
using ApiGraphQL.Services;

namespace ApiGraphQL.Queries
{
    public class QueryMusicCollection
    {
        public MusicCollection GetMusicCollection() 
        {
            var musicCollection = MusicCollectionService.FromJson();
            return musicCollection;
        }
    }
}
