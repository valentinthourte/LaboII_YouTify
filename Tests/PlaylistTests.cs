using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using Entities.Model;
using Entities.Exceptions;
using EjercicioIntegrador2_YouTify.Enums;

namespace Tests
{
    [TestClass]
    public class PlaylistTests
    {

        [TestMethod]
        public async void Test_CreateSpotifyPlaylist_OK()
        {
            // Arrange
            User user = new User("testUser");
            Playlist playlist = new Playlist("1", "playlist1", "", user);

            // Act

            await PlaylistRepository.CreatePlaylist(playlist, EjercicioIntegrador2_YouTify.Enums.EPlatform.Spotify);
            var playlists = await PlaylistRepository.GetPlaylists(user, EjercicioIntegrador2_YouTify.Enums.EPlatform.Spotify);

            // Assert
            Assert.IsTrue(playlists.Count > 0);
        }

        [TestMethod]
        public async void Test_CreateYoutubePlaylist_OK()
        {
            // Arrange
            User user = new User("testUser");
            Playlist playlist = new Playlist("1", "playlist1", "", user);

            // Act

            await PlaylistRepository.CreatePlaylist(playlist, EjercicioIntegrador2_YouTify.Enums.EPlatform.Youtube);
            var playlists = await PlaylistRepository.GetPlaylists(user, EjercicioIntegrador2_YouTify.Enums.EPlatform.Youtube);

            // Assert
            Assert.IsTrue(playlists.Count > 0);
        }

        [TestMethod]
        public async void Test_DuplicateYoutubePlaylists_Error()
        {
            // Arrange
            User user = new User("testUser");
            Playlist playlist = new Playlist("1", "playlist1", "", user);

            // Act
            await PlaylistRepository.CreatePlaylist(playlist, EjercicioIntegrador2_YouTify.Enums.EPlatform.Youtube);

            // Assert
            await Assert.ThrowsExceptionAsync<EDatabaseInsertError>(async () => await PlaylistRepository.CreatePlaylist(playlist, EPlatform.Spotify));
        }
    }
}