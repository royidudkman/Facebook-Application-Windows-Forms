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
        private FacebookFetcherService m_FacebookService = new FacebookFetcherService();
        private FacebookObjectCollection<User> m_CachedFriends;
        private FacebookObjectCollection<Album> m_CachedAlbums;
        private FacebookObjectCollection<Page> m_CachedLikedPages;
        private Page[] m_CachedFavoriteTeams;
        private FacebookObjectCollection<Post> m_CachedPosts;
        private UserAbout m_CachedAbout;

        public FacebookObjectCollection<User> FetchFriends()
        {
            if (m_CachedFriends == null)
            {
                m_CachedFriends = m_FacebookService.FetchFriends();
            }

            return m_CachedFriends;
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {
            if (m_CachedAlbums == null)
            {
                m_CachedAlbums = m_FacebookService.FetchAlbums();
            }

            return m_CachedAlbums;
        }

        public FacebookObjectCollection<Photo> FetchPhotosFromAlbum(Album i_UserAlbum)
        {
            return m_FacebookService.FetchPhotosFromAlbum(i_UserAlbum);
        }

        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            if (m_CachedLikedPages == null)
            {
                m_CachedLikedPages = m_FacebookService.FetchLikedPages();
            }

            return m_CachedLikedPages;
        }

        public Page[] FetchFavoriteTeams()
        {
            if (m_CachedFavoriteTeams == null)
            {
                m_CachedFavoriteTeams = m_FacebookService.FetchFavoriteTeams();
            }

            return m_CachedFavoriteTeams;
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            if (m_CachedPosts == null)
            {
                m_CachedPosts = m_FacebookService.FetchPosts();
            }

            return m_CachedPosts;
        }

        public UserAbout FetchAbout()
        {
            if (m_CachedAbout == null)
            {
                m_CachedAbout = m_FacebookService.FetchAbout();
            }

            return m_CachedAbout;
        }
    }
}