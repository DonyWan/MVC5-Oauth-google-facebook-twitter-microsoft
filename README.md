# MVC5-Oauth-google-facebook-twitter-microsoft
MVC5 Oauth with google,facebook,twitter and microsoft.

> VS2015
> .NET Framework 4.5
> Microsoft.Owin 需要版本`3.1.0.0`

```
// 取消注释以下行可允许使用第三方登录提供程序登录
            /*app.UseMicrosoftAccountAuthentication(
                clientId: "",
                clientSecret: "");
            app.UseTwitterAuthentication(
               consumerKey: "",
               consumerSecret: "");
            app.UseFacebookAuthentication(
               appId: "",
               appSecret: "");
            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "",
                ClientSecret = "
            });*/
```
这里填写申请的key.
