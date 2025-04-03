using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Backend
{
    public class UserDataManager
    {
        public User LoggedInUser { get; private set; }
        public FacebookObjectCollection<string> UserInfo { get; private set; }
        public string UserName { get; private set; }
        public string UserLocation { get; private set; }
        public string UserBirthday { get; private set; }
        public string UserProfilePicURL { get; private set; }
        public string UserCoverPicURL { get; private set; }
        public int UserAge { get; private set; }
        
        public UserDataManager(User i_LoggedInUser)
        {
            InitUserData(i_LoggedInUser);
        }

        public void InitUserData(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            UserName = LoggedInUser.Name;

            setUserLocation();
            setUserBirthdayAndAge();
            setCoverPhoto();
            setProfilePhoto();
            loadUserData();
        }

        private void setUserLocation()
        {
            try
            {
                UserLocation = LoggedInUser.Location.Name;
            }
            catch (Exception)
            {
                UserLocation = string.Empty;
            }
        }

        private void setUserBirthdayAndAge()
        {
            try
            {
                UserBirthday = LoggedInUser.Birthday;
                //DateTime birthDate = DateTime.Parse(UserBirthday);
                DateTime birthDate = DateTime.ParseExact(UserBirthday, "MM/dd/yyyy", null);
                DateTime today = DateTime.Today;
                UserAge = today.Year - birthDate.Year;

                if (birthDate.Month > today.Month || (birthDate.Month == today.Month && birthDate.Day > today.Day))
                {
                    UserAge--;
                }
            }
            catch (Exception)
            {
                UserAge = 0;
                UserBirthday = DateTime.Now.ToShortDateString();
            }
        }

        private void setCoverPhoto()
        {
            string coverPhotoURL = string.Empty;

            foreach(Album photoAlbum in LoggedInUser.Albums)
            {
                if(photoAlbum.Name == "Cover photos")
                {
                    coverPhotoURL = photoAlbum.Photos[0].PictureNormalURL;
                }
            }

            UserCoverPicURL = coverPhotoURL;
        }

        private void setProfilePhoto()
        {
            UserProfilePicURL = LoggedInUser.PictureNormalURL;
        }

        private void loadUserData()
        {
            UserInfo = new FacebookObjectCollection<string>
            {
                $"Lives in: {UserLocation}",
                $"Birthday: {UserBirthday}",
                $"Age: {UserAge.ToString()}",
            };
        }
    }
}
