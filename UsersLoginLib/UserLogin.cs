namespace UsersLoginLib
{
    public class UserLogin
    {
        public string Login(string userName, string userPwd)
        {
            string result = "";
            if(userName == "sam1256" && userPwd == "sam@1256@1256")
            {
                result = "Login success";
            } else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}