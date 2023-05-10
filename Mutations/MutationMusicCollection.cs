using ApiGraphQL.Models;
using ApiGraphQL.Services;

namespace ApiGraphQL.Mutations
{
    public class MutationMusicCollection
    {
        public string addMusicToCollection(MusicItem music) 
        {
            var musicCollection = MusicCollectionService.FromJson();
            musicCollection.Musics.Add(music);

            MusicCollectionService.ToJson(musicCollection);
            return "OK";
        }
    }
}
