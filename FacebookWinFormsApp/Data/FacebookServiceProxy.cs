using BasicFacebookFeatures.interfaces;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Data
{
    internal class FacebookServiceProxy : IFacebookServiceProxy
    {
        private FacebookFetcherService _facebookService = new FacebookFetcherService();
        private FacebookObjectCollection<User> _cachedFriends;
        private FacebookObjectCollection<Album> _cachedAlbums;
        private FacebookObjectCollection<Page> _cachedLikedPages;
        private Page[] _cachedFavoriteTeams;
        private FacebookObjectCollection<Post> _cachedPosts;
        private UserAbout _cachedAbout;

        public FacebookObjectCollection<User> FetchFriends()
        {
            if (_cachedFriends == null)
            {
                _cachedFriends = _facebookService.FetchFriends();
            }
            return _cachedFriends;
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {
            if (_cachedAlbums == null)
            {
                _cachedAlbums = _facebookService.FetchAlbums();
            }
            return _cachedAlbums;
        }

        public FacebookObjectCollection<Photo> FetchPhotosFromAlbum(Album userAlbum)
        {
            return _facebookService.FetchPhotosFromAlbum(userAlbum);
        }

        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            if (_cachedLikedPages == null)
            {
                _cachedLikedPages = _facebookService.FetchLikedPages();
            }
            return _cachedLikedPages;
        }

        public Page[] FetchFavoriteTeams()
        {
            if (_cachedFavoriteTeams == null)
            {
                _cachedFavoriteTeams = _facebookService.FetchFavoriteTeams();
            }
            return _cachedFavoriteTeams;
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            if (_cachedPosts == null)
            {
                _cachedPosts = _facebookService.FetchPosts();
            }
            return _cachedPosts;
        }

        public UserAbout FetchAbout()
        {
            if (_cachedAbout == null)
            {
                _cachedAbout = _facebookService.FetchAbout();
            }
            return _cachedAbout;
        }
    }
}
