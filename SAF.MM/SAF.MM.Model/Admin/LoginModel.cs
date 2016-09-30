namespace SAF.MM.Model.Admin
{
    /// <summary>
    /// 用户实体实体
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        public string PasswordAgain { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string VerificationCode { get; set; }

        /// <summary>
        /// 是否记住密码
        /// </summary>
        public bool IsRemember { get; set; }
    }
}
