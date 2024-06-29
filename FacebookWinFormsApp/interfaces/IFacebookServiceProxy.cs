using BasicFacebookFeatures.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.interfaces
{
    public interface IFacebookServiceProxy 
    {
        FacebookObjectCollection<User> FetchFriends();
        FacebookObjectCollection<Album> FetchAlbums();
        FacebookObjectCollection<Photo> FetchPhotosFromAlbum(Album i_UserAlbum);
        FacebookObjectCollection<Page> FetchLikedPages();
        Page[] FetchFavoriteTeams();
        FacebookObjectCollection<Post> FetchPosts();
        UserAbout FetchAbout(); 
    }
}
